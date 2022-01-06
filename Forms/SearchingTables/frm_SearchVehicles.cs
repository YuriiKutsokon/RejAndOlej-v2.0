using RejAndOlej.DATABASE;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Forms.SearchingTables
{
    public partial class frm_SearchVehicles : Form
    {
        public frm_SearchVehicles()
        {
            InitializeComponent();
            context = new RejAndOlejContext();
        }

        public BusFleet SelectedVehicle
        {
            get => _searchedVehicle;
        }


        private void frm_SearchVehicles_Load(object sender, EventArgs e)
        {
            vehiclesList = context.BusFleets.ToList();
            mainTableInit();
        }

        private void mainTableInit()
        {
            if (vehiclesList != null)
            {
                var viewList = TableViewHelpers.GetView<FleetMainTableView>(vehiclesList);
                dgvVehicles.DataSource = viewList;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GetVehicle(object sender, EventArgs e)
        {
            DataGridView gridView = dgvVehicles;

            _searchedVehicle = GridViewHelpers.GetObjectFromDataGridViewRow<BusFleet>(gridView, "RegistrationNumber");
            DialogResult = DialogResult.OK;
        }
    }
}
