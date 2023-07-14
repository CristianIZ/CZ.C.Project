using Cz.Project.Abstraction;
using Cz.Project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cz.Project.UI.Forms.Helpers
{
    public static class TreeViewHelper
    {
        public static void FillLicenseTreeView(IList<ComponentDto> tree, TreeView licenseTreeView, List<LicenseDto> assignedLicenses = null)
        {
            foreach (var item in tree)
            {
                var node = new TreeNode()
                {
                    Text = item.Name,
                    Tag = item,
                };

                if (assignedLicenses != null)
                {
                    if (assignedLicenses.Where(l => l.LicenseCode == item.LicenseCode).Any())
                        node.Checked = true;
                }

                PopulateTree(ref node, ((ParentLicenseDto)item).GetChilds(), assignedLicenses);
                licenseTreeView.Nodes.Add(node);
            }

            licenseTreeView.ExpandAll();
        }

        private static void PopulateTree(ref TreeNode root, IList<ComponentDto> tree, List<LicenseDto> assignedLicenses)
        {
            foreach (var detail in tree)
            {
                var child = new TreeNode()
                {
                    Text = detail.Name,
                    Tag = detail
                };

                root.Nodes.Add(child);

                // Si el usuario tiene permisos asignados marca a los padres
                if (assignedLicenses != null)
                {
                    if (assignedLicenses.Where(l => l.LicenseCode == detail.LicenseCode).Any())
                    {
                        child.Checked = true;
                        root.Checked = true;
                        CheckParents(root);
                    }
                }

                var childs = detail.GetChilds();

                if (childs != null)
                    PopulateTree(ref child, detail.GetChilds(), assignedLicenses);
            }
        }

        /// <summary>
        /// Usar con evento after checked
        /// Segun el nodo chequeado actualiza los padres e hijos
        /// </summary>
        /// <param name="e"></param>
        public static void CheckNodeBeheavor(TreeViewEventArgs e)
        {
            if (e.Node.Checked)
            {
                CheckParents(e.Node);
                CheckChilds(e.Node, true);
            }
            else
            {
                UnCheckParents(e.Node);
                CheckChilds(e.Node, false);
            }
        }

        /// <summary>
        /// Usar con evento after checked
        /// Segun el nodo chequeado actualiza los padres e hijos
        /// </summary>
        /// <param name="node"></param>
        public static void CheckNodeBeheavor(TreeNode node)
        {
            if (node.Checked)
            {
                CheckParents(node);
                CheckChilds(node, true);
            }
            else
            {
                UnCheckParents(node);
                CheckChilds(node, false);
            }
        }

        private static bool SiblingsChecked(TreeNode node)
        {
            var allNodes = GetSiblings(node, new List<TreeNode>(), false);

            if (allNodes.Where(n => n.Checked).Count() > 0)
                return true;
            else
                return false;
        }

        private static List<TreeNode> GetSiblings(TreeNode node, List<TreeNode> treeNodes, bool startPointReached)
        {
            // Voy al primero de los nodos
            if (node.PrevNode != null && !startPointReached)
                GetSiblings(node.PrevNode, treeNodes, startPointReached);
            else if (!startPointReached)
                startPointReached = true;


            if (startPointReached)
            {
                treeNodes.Add(node);

                if (node.NextNode != null)
                    GetSiblings(node.NextNode, treeNodes, startPointReached);
            }

            return treeNodes;
        }

        /// <summary>
        /// Marca los antecesores del nodo seleccionado
        /// </summary>
        /// <param name="node"></param>
        private static void CheckParents(TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Parent.Checked = true;
                CheckParents(node.Parent);
            }
        }

        /// <summary>
        /// Desmarca los antecesores del nodo seleccionado 
        /// (Si los hermanos estan marcados el padre no sera desmarcado)
        /// </summary>
        /// <param name="node"></param>
        private static void UnCheckParents(TreeNode node)
        {
            if (!SiblingsChecked(node))
            {
                if (node.Parent != null)
                {
                    node.Parent.Checked = false;
                    UnCheckParents(node.Parent);
                }
            }
        }

        /// <summary>
        /// Marca o desmarca los hijos del nodo seleccionado
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check">Marcar = true, desmarcar = false</param>
        private static void CheckChilds(TreeNode node, bool check)
        {
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode item in node.Nodes)
                {
                    item.Checked = check;
                    CheckChilds(item, check);
                }
            }
        }

        /// <summary>
        /// Obtiene las hojas del arbol
        /// </summary>
        /// <param name="root"></param>
        /// <param name="licenses"></param>
        /// <returns></returns>
        public static List<LicenseDto> GetCheckedLeafs(TreeNodeCollection root, List<LicenseDto> licenses)
        {
            foreach (TreeNode node in root)
            {
                if (node.Nodes.Count > 0)
                {
                    GetCheckedLeafs(node.Nodes, licenses);
                }
                else if (node.Nodes.Count == 0 && node.Checked)
                {
                    var name = ((LicenseDto)node.Tag).Name;
                    var code = ((LicenseDto)node.Tag).LicenseCode;

                    licenses.Add(new LicenseDto(name, code, 0));
                }
            }

            return licenses;
        }

        /// <summary>
        /// Obtiene las hojas del arbol
        /// </summary>
        /// <param name="root"></param>
        /// <param name="licenses"></param>
        /// <returns></returns>
        public static List<LicenseDto> GetLeafs(TreeNodeCollection root, List<LicenseDto> licenses)
        {
            foreach (TreeNode node in root)
            {
                if (node.Nodes.Count > 0)
                {
                    GetLeafs(node.Nodes, licenses);
                }
                else if (node.Nodes.Count == 0)
                {
                    var name = ((LicenseDto)node.Tag).Name;
                    var code = ((LicenseDto)node.Tag).LicenseCode;

                    licenses.Add(new LicenseDto(name, code, 0));
                }
            }

            return licenses;
        }

        /// <summary>
        /// Obtiene toda la densendecia en forma de lista de licencias
        /// </summary>
        /// <param name="root"></param>
        /// <param name="licenses"></param>
        /// <returns></returns>
        public static IList<LicenseDto> GetDescent(TreeNodeCollection root, List<LicenseDto> licenses)
        {

            foreach (TreeNode node in root)
            {
                var name = ((LicenseDto)node.Tag).Name;
                var code = ((LicenseDto)node.Tag).LicenseCode;

                licenses.Add(new LicenseDto(name, code, 0));

                if (node.Nodes.Count > 0)
                {
                    GetDescent(node.Nodes, licenses);
                }
            }

            return licenses;
        }

        /// <summary>
        /// Convierte el treeview a la version composite del mismo
        /// </summary>
        /// <param name="rootNodes"></param>
        /// <returns></returns>
        public static IList<ComponentDto> TreviewToComposite(TreeNodeCollection rootNodes)
        {
            IList<ComponentDto> listComponent = new List<ComponentDto>();

            foreach (TreeNode item in rootNodes)
            {
                var name = ((LicenseDto)item.Tag).Name;
                var code = ((LicenseDto)item.Tag).LicenseCode;

                if (item.Nodes.Count == 0)
                {
                    var license = new LicenseDto(name, code, 0);
                    listComponent.Add(license);
                }
                else
                {
                    var parentLicense = new ParentLicenseDto(name, code, 0);
                    TreeViewHelper.ConvertToComposite(item.Nodes, parentLicense);

                    listComponent.Add(parentLicense);
                }
            }

            return listComponent;
        }

        /// <summary>
        /// Recorre recursivamente el treeview y lo comvierte a conposite
        /// Usar con TreviewToComposite()
        /// </summary>
        /// <param name="root">Base del treeview</param>
        /// <param name="componentDto">Componente que va a contener todas las licencias</param>
        private static void ConvertToComposite(TreeNodeCollection root, ComponentDto componentDto)
        {
            foreach (TreeNode node in root)
            {
                var name = ((LicenseDto)node.Tag).Name;
                var code = ((LicenseDto)node.Tag).LicenseCode;

                if (node.Nodes.Count == 0)
                {
                    var license = new LicenseDto(name, code, 0);
                    componentDto.AddChild(license);
                }
                else
                {
                    var parentLicense = new ParentLicenseDto(name, code, 0);
                    componentDto.AddChild(parentLicense);

                    ConvertToComposite(node.Nodes, parentLicense);
                }
            }
        }
    }
}
