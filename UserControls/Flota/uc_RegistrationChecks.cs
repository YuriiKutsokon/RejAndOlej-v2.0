using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Models;
using RejAndOlej.Views.TableViews;

namespace RejAndOlej.UserControls.Flota
{
    public partial class uc_RegistrationChecks : UserControl
    {
        public uc_RegistrationChecks()
        {
            InitializeComponent();

            context = new RejAndOlejContext();
        }

        private void RegisterEvents()
        {

        }

        private void initDataGridView()
        {
            ICollection<RegistrationCheck> checkslist = context.RegistrationChecks.ToList();
            var mainView = RegistrationChecksMainTableView.GetRegistrationChecksListView(checkslist);
            dataGridViewRegistrationChecksList.DataSource = mainView;
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            frm_SearchVehicles frm_Search = new frm_SearchVehicles();
            if (frm_Search.ShowDialog() == DialogResult.OK)
            {
                selectedVehicle = frm_Search.SelectedVehicle;

                if (selectedVehicle != null)
                {
                    tbModelName.Text = selectedVehicle.Bus.BusMaker.Name + " " + selectedVehicle.Bus.ModelName;
                    tbRegistrationNumber.Text = selectedVehicle.RegistrationNumber;
                    tbMileage.Text = selectedVehicle.Mileage.ToString();
                }
            }
        }
    }
}
