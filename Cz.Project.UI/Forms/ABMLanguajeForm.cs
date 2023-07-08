using Cz.Project.Abstraction;
using Cz.Project.GenericServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cz.Project.UI
{
    public partial class ABMLanguajeForm : Form
    {
        public ABMLanguajeForm()
        {
            InitializeComponent();
        }

        private void ABMLanguajeForm_Load(object sender, EventArgs e)
        {
            InitializeCombobox();
        }

        private void btnAddLanguaje_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewLanguaje.Text.Trim()))
            {
                MessageBox.Show("Ingrese un nombre para el lenguaje");
                return;
            }

            var tService = new TranslationService();
            tService.AddLanguaje(txtNewLanguaje.Text.Trim());
            InitializeCombobox();
        }

        private void btnSetTranslation_Click(object sender, EventArgs e)
        {
            if(cmbWord.SelectedItem == null)
            {
                MessageBox.Show("Ninguna palabra para traducir seleccionada");
                return;
            }

            if (string.IsNullOrEmpty(txtTranslation.Text.Trim()))
            {
                MessageBox.Show("Ninguna palabra para asignar");
                return;
            }

            if (cmbSourceLanguaje.SelectedItem == null)
            {
                MessageBox.Show("Lenguaje de origen no seleccionado");
                return;
            }

            if (cmbTargetLanguaje.SelectedItem == null)
            {
                MessageBox.Show("Lenguaje de destino no seleccionado");
                return;
            }

            try
            {
                var wordtoParsed = (WordDto)cmbWord.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Palabra seleccionada no valida");
            }

            try
            {
                var wordtoParsed = (LanguajeDto)cmbSourceLanguaje.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lenguaje de origen no valido");
            }

            try
            {
                var wordtoParsed = (LanguajeDto)cmbTargetLanguaje.SelectedItem;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lenguaje de destino no valido");
            }

            var tService = new TranslationService();
            tService.AddWord((LanguajeDto)cmbSourceLanguaje.SelectedItem, (LanguajeDto)cmbTargetLanguaje.SelectedItem, (WordDto)cmbWord.SelectedItem, txtTranslation.Text.Trim());

        }

        public void InitializeCombobox()
        {
            cmbSourceLanguaje.Items.Clear();
            cmbTargetLanguaje.Items.Clear();
            cmbWord.Items.Clear();

            cmbSourceLanguaje.ResetText();
            cmbTargetLanguaje.ResetText();
            cmbWord.ResetText();

            var tService = new TranslationService();
            var languajes = tService.GetLanguages();

            foreach (var item in languajes)
            {
                cmbSourceLanguaje.Items.Add(item);
            }
        }

        private void cmbSourceLanguaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbWord.Items.Clear();
            cmbTargetLanguaje.Items.Clear();
            cmbTargetLanguaje.ResetText();
            cmbWord.ResetText();

            if (cmbSourceLanguaje.SelectedItem == null)
                return;

            var tService = new TranslationService();

            var languajes = tService.GetLanguages();
            foreach (var item in languajes)
            {
                if (item.Code != ((LanguajeDto)cmbSourceLanguaje.SelectedItem).Code)
                    cmbTargetLanguaje.Items.Add(item);
            }

            var words = tService.GetWords((LanguajeDto)cmbSourceLanguaje.SelectedItem);
            foreach (var item in words)
            {
                cmbWord.Items.Add(item);
            }
        }

        private void Validations()
        {

        }
    }
}
