using Cz.Project.Abstraction;
using Cz.Project.Dto.Enums;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
using Cz.Project.SQLContext.Services;
using Cz.Project.UI.Enums;
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
            try
            {
                if (cmbLanguaje.SelectedItem == null)
                    return;

                var selectedLang = _languajes.Where(w => w.Name.Equals(cmbLanguaje.SelectedItem)).First();

                if (!ValidateLanguajeComplete(selectedLang))
                    throw new ApplicationException("No se puede elegir el idioma porque no esta completo");

                if (ValidateLanguajeExistence(selectedLang))
                    TranslationHelper.Translation.ChangeLenguaje(selectedLang);
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("No es posible cambiar el idioma");
            }
        }

        private bool ValidateLanguajeComplete(LanguajeDto selectedLanguaje)
        {
            var wordContext = new WordContext();
            var words = wordContext.GetWordsByLanguaje(selectedLanguaje.Code);

            var enumList = (MainFormWordsEnum[])Enum.GetValues(typeof(MainFormWordsEnum));

            if (words == null)
                return false;

            foreach (MainFormWordsEnum item in enumList)
            {
                if (!words.Select(w => w.Code).Contains((int)item))
                    return false;
            }

            return true;
        }

        private bool ValidateLanguajeExistence(LanguajeDto selectedLanguaje)
        {
            if (!_languajes.Select(a => a.Name).Contains(selectedLanguaje.Name))
            {
                MessageBox.Show("El lenguaje seleccionado no es un lenguaje disponible");
                return false;
            }

            return true;
        }
    }
}
