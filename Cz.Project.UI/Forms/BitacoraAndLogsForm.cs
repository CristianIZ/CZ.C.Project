using Cz.Project.Abstraction.Enums;
using Cz.Project.Dto.Enums;
using Cz.Project.GenericServices;
using Cz.Project.GenericServices.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cz.Project.UI.Forms
{
    public partial class BitacoraAndLogsForm : Form
    {
        public BitacoraAndLogsForm()
        {
            InitializeComponent();
        }

        private void BitacoraAndLogsForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(LogTypeCodeEnum)))
            {
                cmbType.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(EventTypeEnum)))
            {
                cmbType.Items.Add(item);
            }

            this.ResetView();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedItem == null)
                return;

            lstBitacora.Items.Clear();

            if (cmbType.SelectedItem.GetType() == typeof(EventTypeEnum))
            {
                var getPagedBitacore = new BitacoraService().GetByEventType((EventTypeEnum)cmbType.SelectedItem, 0, 20);

                foreach (var item in getPagedBitacore)
                {
                    lstBitacora.Items.Add(item);
                }
            }
            else if (cmbType.SelectedItem.GetType() == typeof(LogTypeCodeEnum))
            {
                var getPagedLogs = LogHelper.GetByLogType((LogTypeCodeEnum)cmbType.SelectedItem, 0, 20);

                foreach (var item in getPagedLogs)
                {
                    lstBitacora.Items.Add(item);
                }
            }
            else
            {
                ResetView();
            }
        }

        public void ResetView()
        {
            lstBitacora.Items.Clear();

            var getPagedBitacore = new BitacoraService().Get(0, 20);
            var getPagedLogs = LogHelper.GetLogs(0, 20);

            foreach (var item in getPagedBitacore)
            {
                lstBitacora.Items.Add(item);
            }

            foreach (var item in getPagedLogs)
            {
                lstBitacora.Items.Add(item);
            }
        }
    }
}
