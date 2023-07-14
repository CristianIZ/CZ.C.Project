using Cz.Project.Abstraction;
using Cz.Project.Abstraction.License_Composite;
using Cz.Project.Domain;
using Cz.Project.SQLContext.Services;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Linq;
using System.Xml;

namespace Cz.Project.GenericServices
{
    public class LicenseService
    {
        public IList<LicenseDto> Getall()
        {
            var licenses = new LicensesContext().GetAll();
            var result = new List<LicenseDto>();

            foreach (var item in licenses)
            {
                result.Add(MapLicense(item));
            }

            return result;
        }

        /// <summary>
        /// Get from database and builds the composite
        /// </summary>
        /// <returns></returns>
        public IList<ComponentDto> GetLicenseTree()
        {
            var licenses = new LicensesContext().GetAll();
            var licenseLicense = new LicenseLicenseContext().GetAll();

            var licenseRelation = MapToCodeRelation(licenses, licenseLicense);

            return BuildTree(licenses, licenseRelation);
        }

        #region Build tree recursive section
        /// <summary>
        /// Builds a tree with given licenses and relations
        /// </summary>
        /// <param name="licenses">All the licenses</param>
        /// <param name="licenseRelation">All the relations</param>
        /// <returns></returns>
        public IList<ComponentDto> BuildTree(IList<License> licenses, IList<LicenseCodeRelation> licenseRelation)
        {
            var familyGroup = licenseRelation.GroupBy(f => f.FamilyLicense.Id)
                                             .Select(group => new { familyId = group.Key, familyDto = group.ToList() })
                                             .Select(f => f.familyDto)
                                             .ToList();

            var linceseTree = new List<ComponentDto>();

            foreach (var familyList in familyGroup)
            {
                var rootLicenses = GetRootLicenses(licenses, familyList);

                foreach (var rootlicense in rootLicenses)
                {
                    var root = (ParentLicenseDto)MapLicense(rootlicense, true);
                    FillRootLicense(rootlicense, ref root, licenses, familyList);
                    linceseTree.Add(root);
                }
            }

            return linceseTree;
        }

        private IList<License> GetRootLicenses(IList<License> licenses, IList<LicenseCodeRelation> licenseRelation)
        {
            IList<License> rootLicenses = new List<License>();


            // Cuando no tiene padre es root
            var roots = licenseRelation.Where(p => p.ParentCode == 0).ToList();

            foreach (var rootlicense in roots)
            {
                rootLicenses.Add(licenses.Where(l => l.Code == rootlicense.ChildCode).First());
            }

            // // Recorro todas las licencias
            // foreach (var license in licenses)
            // {
            //     // Cuando no es hijo de nadie es Root
            //     if (licenseRelation.Where(lr => lr.ParentCode == license.Code).Count() == 0)
            //         rootLicenses.Add(license);
            // }

            return rootLicenses;
        }

        /// <summary>
        /// Recursive function that build the tree for the given license
        /// </summary>
        private void FillRootLicense(License rootLic, ref ParentLicenseDto familyRoot, IList<License> licenses, IList<LicenseCodeRelation> relations)
        {
            var childs = GetChilds(rootLic, licenses, relations);

            foreach (var item in childs)
            {
                if (GetChilds(item, licenses, relations).Count > 0)
                {
                    var family = (ParentLicenseDto)MapLicense(item, true);
                    familyRoot.AddChild(family);
                    FillRootLicense(item, ref family, licenses, relations);
                }
                else
                {
                    familyRoot.AddChild(MapLicense(item, false));
                }
            }
        }

        /// <summary>
        /// Look for all the childs of the license
        /// </summary>
        private IList<License> GetChilds(License license, IList<License> licenses, IList<LicenseCodeRelation> relations)
        {
            var childRelations = relations.Where(r => r.ParentCode == license.Code).ToList();

            IList<License> result = new List<License>();

            foreach (var item in childRelations)
            {
                result.Add(licenses.Where(l => l.Code == item.ChildCode).First());
            }

            return result;
        }
        #endregion

        public int GetNewCode(IList<License> licenses)
        {
            return licenses.Max(l => l.Code) + 1;
        }

        public void AddLicensesAndRelations(IList<License> allLicenses, IList<LicenseCodeRelation> allRelations)
        {
            AddLicenses(allLicenses);
            var licensesToAdd = NewRelationsList(allRelations);
            new LicenseLicenseContext().Add(licensesToAdd);
        }

        public void AddLicenses(IList<License> allLicenses)
        {
            var licContext = new LicensesContext();

            var licenses = licContext.GetAll();
            var licensesToAdd = new List<License>();

            foreach (var license in allLicenses)
            {
                if (!licenses.Any(l => l.Code == license.Code))
                    licensesToAdd.Add(license);
            }

            licContext.Add(licensesToAdd);
        }

        /// <summary>
        /// Busca las nuevas licencias no existentes a agregar
        /// </summary>
        /// <param name="allRelations"></param>
        /// <returns></returns>
        public List<LicenseLicense> NewRelationsList(IList<LicenseCodeRelation> allRelations)
        {
            var licRelContext = new LicenseLicenseContext();
            var licContext = new LicensesContext();

            var newRelations = allRelations.Where(r => r.Id == 0).ToList();
            var result = new List<LicenseLicense>();

            foreach (var relation in newRelations)
            {
                var parentLic = licContext.GetByCode(relation.ParentCode);
                var childLic = licContext.GetByCode(relation.ChildCode);

                result.Add(new LicenseLicense()
                {
                    IdPadre = parentLic.Id,
                    IdHijo = childLic.Id
                });
            }

            return result;
        }

        /// <summary>
        /// Si tiene hijo pero no tiene padre = root license
        /// Si tiene padre e hijo es rama
        /// No se puede dar la condicion de no tener hijos ya que cada licencia (hijo) apunta a su padre
        /// gracias a esto una licencia sera hoja unicamente cuando no se especifique ningun hijo en la tabla
        /// por lo tanto para ser hoja = no existe el registro del hijo (Ej: nadie tiene como padre el Id 4)
        /// </summary>
        /// <param name="allRelations"></param>
        /// <returns></returns>
        public List<LicenseLicense> MapLicencesLicences(IList<LicenseCodeRelation> allRelations)
        {
            var licRelContext = new LicenseLicenseContext();
            var licences = new LicensesContext().GetAll();

            var result = new List<LicenseLicense>();

            foreach (var relation in allRelations)
            {
                if (relation.ParentCode == 0 && relation.Id == 0)
                    throw new Exception("No se puede agregar una relacion sin informacion de padre ni hijo");

                int parentLic = 0;
                int childLic = 0;

                if (relation.ParentCode == 0)
                {
                    childLic = licences.Where(l => l.Code == relation.Id).First().Id;
                }
                else if (relation.Id == 0)
                {
                    parentLic = licences.Where(l => l.Code == relation.ParentCode).First().Id;
                }
                else
                {
                    childLic = licences.Where(l => l.Code == relation.Id).First().Id;
                    parentLic = licences.Where(l => l.Code == relation.ParentCode).First().Id;
                }

                result.Add(new LicenseLicense()
                {
                    IdPadre = parentLic,
                    IdHijo = childLic
                });
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="codeRelations"></param>
        public void SaveNewFamily(IList<LicenseCodeRelation> codeRelations, string familyName)
        {
            var licenseContext = new LicenseLicenseContext();

            var familyLicense = new FamilyLicenses()
            {
                Name = familyName
            };

            var licensesToSave = MapLicencesLicences(codeRelations);

            licenseContext.AddFamilyLicense(familyLicense);
            var lastFamilyId = licenseContext.GetLastFamily();

            foreach (var license in licensesToSave)
            {
                license.FamilyLicense = new FamilyLicenses()
                {
                    Id = lastFamilyId
                };
            }

            licenseContext.Add(licensesToSave);
        }


        /// <summary>
        /// Convierte el componente con sus hijos en una lista relacionando padre e hijo de cada rama y hoja
        /// </summary>
        /// <param name="components"></param>
        /// <returns></returns>
        public IList<LicenseCodeRelation> ConverToCodeRelation(IList<ComponentDto> components)
        {
            var relations = new List<LicenseCodeRelation>();
            var allLicenses = new LicensesContext().GetAll();

            foreach (var component in components)
            {
                relations.Add(new LicenseCodeRelation()
                {
                    Id = allLicenses.Where(x => x.Code == component.LicenseCode).First().Id,
                    ParentCode = 0
                });

                LoadRecursiveRelations(component, relations, allLicenses);
            }

            return relations;
        }

        private void LoadRecursiveRelations(ComponentDto component, IList<LicenseCodeRelation> relations, IList<License> allLicenses)
        {
            var childs = component.GetChilds();

            if (childs != null && childs.Any())
            {
                foreach (var child in childs)
                {
                    relations.Add(new LicenseCodeRelation()
                    {
                        Id = allLicenses.Where(x => x.Code == child.LicenseCode).First().Id,
                        ParentCode = component.LicenseCode,
                    });

                    LoadRecursiveRelations(child, relations, allLicenses);
                }
            }
        }

        public ComponentDto MapLicense(License license, bool hasChilds)
        {
            if (hasChilds)
                return new ParentLicenseDto(license.Name, license.Code, 0);
            else
                return new LicenseDto(license.Name, license.Code, 0);
        }


        public LicenseDto MapLicense(License license)
        {
            return new LicenseDto(license.Name, license.Code, 0);
        }

        public IList<LicenseCodeRelation> MapToCodeRelation(IList<License> licenses, IList<LicenseLicense> licenseRelation)
        {
            var result = new List<LicenseCodeRelation>();

            foreach (var item in licenseRelation)
            {

                if (item.IdPadre == 0)
                {
                    result.Add(new LicenseCodeRelation()
                    {
                        Id = item.Id,
                        ChildCode = licenses.Where(l => l.Id == item.IdHijo).First().Code,
                        ParentCode = 0,
                        FamilyLicense = MapFamilyLicense(item.FamilyLicense)
                    });
                }
                else
                {
                    result.Add(new LicenseCodeRelation()
                    {
                        Id = item.Id,
                        ChildCode = licenses.Where(l => l.Id == item.IdHijo).First().Code,
                        ParentCode = licenses.Where(l => l.Id == item.IdPadre).First().Code,
                        FamilyLicense = MapFamilyLicense(item.FamilyLicense)
                    });
                }
            }

            return result;
        }

        public FamilyLicenseDto MapFamilyLicense(FamilyLicenses familyLicense)
        {
            return new FamilyLicenseDto()
            {
                Id = familyLicense.Id,
                Name = familyLicense.Name
            };
        }
    }
}
