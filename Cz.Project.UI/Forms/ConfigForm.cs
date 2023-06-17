using Cz.Project.Abstraction;
using Cz.Project.Dto.Enums;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class ConfigForm : Form
    {
        private IList<LanguajeDto> _languajes;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            var translationService = new TranslationService();

            _languajes = translationService.GetLanguages();
            var languajeNames = _languajes.Select(a => a.Name);

            foreach (var item in languajeNames)
            {
                cmbLanguaje.Items.Add(item);
            }
        }

        private void cmbLanguaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguaje.SelectedItem == null)
                return;

            if (ValidateLanguajeExistence((string)cmbLanguaje.SelectedItem))
            {
                var selectedLang = _languajes.Where(w => w.Name.Equals(cmbLanguaje.SelectedItem)).First();
                TranslationHelper.Translation.ChangeLenguaje(selectedLang);
            }

        }

        private bool ValidateLanguajeExistence(string languajeName)
        {
            if (!_languajes.Select(a => a.Name).Contains(languajeName))
            {
                MessageBox.Show("El lenguaje seleccionado no es un lenguaje disponible");
                return false;
            }

            return true;
        }
    }
}
