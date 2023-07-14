using Cz.Project.Abstraction;
using Cz.Project.GenericServices;
using Cz.Project.SQLContext.Services;
using Cz.Project.UI.Forms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cz.Project.UI.Forms
{
    public partial class FamilyLicenseForm : Form
    {
        public FamilyLicenseForm()
        {
            InitializeComponent();
        }

        private void FamilyLicenseForm_Load(object sender, EventArgs e)
        {
            var licenseService = new LicenseService();

            var licenses = licenseService.Getall();

            foreach (var item in licenses)
            {
                lstLicenses.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstLicenses.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un item de la lista de la izquierda");
                return;
            }

            if (treeviewNewFamily.SelectedNode == null)
            {
                // Root license
                var license = (LicenseDto)lstLicenses.SelectedItem;
                treeviewNewFamily.Nodes.Add(new TreeNode()
                {
                    Tag = license,
                    Text = license.Name
                });
            }
            else
            {
                var license = (LicenseDto)lstLicenses.SelectedItem;
                treeviewNewFamily.SelectedNode.Nodes.Add(new TreeNode()
                {
                    Tag = license,
                    Text = license.Name
                });
            }

            treeviewNewFamily.ExpandAll();
            lstLicenses.Items.RemoveAt(lstLicenses.SelectedIndex);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (treeviewNewFamily.SelectedNode == null)
            {
                MessageBox.Show("Seleccione un item de la lista de la derecha");
                return;
            }

            var licenses = TreeViewHelper.GetDescent(this.treeviewNewFamily.SelectedNode.Nodes, new List<LicenseDto>());

            var currentName = ((LicenseDto)this.treeviewNewFamily.SelectedNode.Tag).Name;
            var currentCode = ((LicenseDto)this.treeviewNewFamily.SelectedNode.Tag).LicenseCode;

            licenses.Add(new LicenseDto(currentName, currentCode, 0));

            foreach (var license in licenses)
            {
                lstLicenses.Items.Add(license);
            }

            this.treeviewNewFamily.SelectedNode.Remove();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (treeviewNewFamily.Nodes.Count == 0)
            {
                MessageBox.Show("La lista de la derecha debe contener elementos para ser guardada");
                return;
            }

            var components = TreeViewHelper.TreviewToComposite(treeviewNewFamily.Nodes);

            var licenseService = new LicenseService();
            var relations = licenseService.ConverToCodeRelation(components);

            licenseService.SaveNewFamily(relations, txtName.Text);
        }
    }
}
