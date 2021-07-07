using RejAndOlej.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Views.TableViews;

namespace RejAndOlej.Forms.Tables
{
    public partial class frm_FleetVehciclesList : Form
    {
        public frm_FleetVehciclesList()
        {
            InitializeComponent();
            InitDataGridView();
        }

        private void FleetVehciclesList_Load(object sender, EventArgs e)
        {

        }

        public BusFleet GetFocusedRow()
        {
            BusFleet rowToExport = null;

            if (dataGridViewFleetList.SelectedRows.Count == 1)
                rowToExport = GridViewHelper.GetObjectFromDataGridViewRow<BusFleet>(dataGridViewFleetList, "RegistrationNumber");
            else
                MessageBox.Show("Wybierz jeden pojazd");

            return rowToExport;
        }

        private void InitDataGridView()
        {
            ICollection<BusFleet> fleetVechicles = context.BusFleets.ToList();
            var mainView = FleetMainTableView.GetFleetView(fleetVechicles);
            dataGridViewFleetList.DataSource = mainView;
        }

        private void toolStripButtonConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
