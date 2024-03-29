﻿using System;
using System.Windows.Forms;
using Cz.Project.Abstraction;
using Cz.Project.UI.Forms.Helpers;
using Cz.Project.GenericServices.Helpers;

namespace Cz.Project.UI.Forms
{
    public partial class LicenseForm : Form
    {
        InMemoryLicenses inMemoryLicenses;

        public LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            this.inMemoryLicenses = new InMemoryLicenses();
            RefreshTreeView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.licensesTreeView.SelectedNode == null)
                {
                    this.inMemoryLicenses.AddLicense(txtLicenseName.Text, 0);
                }
                else
                {
                    var select = (ComponentDto)this.licensesTreeView.SelectedNode.Tag;
                    this.inMemoryLicenses.AddLicense(txtLicenseName.Text, select.LicenseCode);
                }

                RefreshTreeView();
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                this.inMemoryLicenses.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo salio mal");
            }
        }

        private void RefreshTreeView()
        {
            this.licensesTreeView.Nodes.Clear();
            TreeViewHelper.FillLicenseTreeView(this.inMemoryLicenses.GetTree(), this.licensesTreeView);
            this.licensesTreeView.ExpandAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
