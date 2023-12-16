using Cz.Project.Domain;
using Cz.Project.SQLContext.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Cz.Project.SQLContext.Services
{
    public class LicenseLicenseContext
    {
        public IList<LicenseLicense> GetAll()
        {
            string query = $"SELECT * FROM [LicenseLicense]";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadLicenses(table);
            }
        }

        public void AddFamilyLicense(FamilyLicenses familyLicenses)
        {
            var commands = new List<SqlCommand>();
            var query = $"INSERT INTO [FamilyLicenses] ([Name]) VALUES (@Name);";

            using (var DA = new SQLDataAccess())
            {
                var sqlParameters = new ArrayList();
                sqlParameters.Add(SqlHelper.CreateParameter("Name", familyLicenses.Name));

                commands.Add(DA.CreateCommand(query, sqlParameters));

                DA.InsertAllCommands(commands);
            }
        }

        public int GetLastFamily()
        {
            string query = $"SELECT TOP (1) [Id] FROM [FamilyLicenses] ORDER BY [Id] DESC";

            using (var DA = new SQLDataAccess())
            {
                var table = DA.Read(query);
                return ReadInt(table, "Id");
            }
        }

        public IList<LicenseLicense> GetByFamilyLicenseId(int familyLicenseId)
        {
            string query = $"SELECT * FROM [dbo].[LicenseLicense] WHERE FamilyLicenseId = @FamilyLicenseId";

            var sqlParameters = new ArrayList();
            sqlParameters.Add(SqlHelper.CreateParameter("FamilyLicenseId", familyLicenseId));

            IList<LicenseLicense> result;
            using (var DA = new SQLDataAccess())
            {
                var tabla = DA.Read(query, sqlParameters);
                result = ReadLicenses(tabla);
            }

            return result;
        }

        public int ReadInt(DataTable table, string columnToRead)
        {
            IList<LicenseLicense> licenses = new List<LicenseLicense>();

            foreach (DataRow item in table.Rows)
            {
                return Convert.ToInt32(item[$"{columnToRead}"]);
            }

            throw new ApplicationException("No se encontro ningun entero para leer");
        }

        public IList<LicenseLicense> ReadLicenses(DataTable table)
        {
            IList<LicenseLicense> licenses = new List<LicenseLicense>();

            foreach (DataRow item in table.Rows)
            {
                licenses.Add(MapLicense(item));
            }

            return licenses;
        }

        public LicenseLicense MapLicense(DataRow dataRow)
        {
            return new LicenseLicense()
            {
                Id = Convert.ToInt32(dataRow["Id"]),
                IdPadre = Convert.ToInt32(dataRow["IdPadre"]),
                IdHijo = Convert.ToInt32(dataRow["IdHijo"]),
                FamilyLicense = new FamilyLicenses()
                {
                    Id = Convert.ToInt32(dataRow["FamilyLicenseId"])
                },
            };
        }

        public void Add(IList<LicenseLicense> licRel)
        {
            var commands = new List<SqlCommand>();
            var query = $"INSERT INTO LicenseLicense ([IdPadre], [IdHijo], [FamilyLicenseId]) VALUES (@IdPadre, @IdHijo, @FamilyLicenseId);";

            using (var DA = new SQLDataAccess())
            {
                foreach (var item in licRel)
                {
                    var sqlParameters = new ArrayList();
                    sqlParameters.Add(SqlHelper.CreateParameter("IdPadre", item.IdPadre));
                    sqlParameters.Add(SqlHelper.CreateParameter("IdHijo", item.IdHijo));
                    sqlParameters.Add(SqlHelper.CreateParameter("FamilyLicenseId", item.FamilyLicense.Id));

                    commands.Add(DA.CreateCommand(query, sqlParameters));
                }

                DA.InsertAllCommands(commands);
            }
        }
    }
}
