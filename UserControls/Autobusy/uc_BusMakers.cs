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
using RejAndOlej.Views.TableViews;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Service;
using RejAndOlej.DATABASE;
using static RejAndOlej.Enums.EnModels;
using RejAndOlej.Helpers;

namespace RejAndOlej.UserControls.Autobusy
{
    public partial class uc_BusMakers : BaseUserControl
    {
        public uc_BusMakers() 
        {
            InitializeComponent();
            context = new RejAndOlejContext();

            initDataGrid();

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            dataGridViewBusMakersList.RowStateChanged += (s, e) => initManipulationControls();
            dataGridViewBusMakersList.CellStateChanged += (s, e) => initManipulationControls();

            dataGridViewBusMakersList.DoubleClick += (s, e) => { groupBoxDataManipulation.Enabled = true; DBAction = ModelActions.Edit; };
        }

        private void initManipulationControls()
        {
            var selectedObject = GridViewHelpers.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList, "");

            if (selectedObject != null)
            {
                textBoxName.Text = selectedObject.Name;
                textBoxNation.Text = selectedObject.Nation;
            }

        }

        private void initDataGrid()
        {
            ICollection<BusMaker> busMakersList = context.BusMakers.ToList();
            displayList = TableViewHelpers.GetView<BusMakersMainTableView>(busMakersList);
            dataGridViewBusMakersList.DataSource = displayList;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = ModelActions.Insert;

            textBoxName.Text = "";
            textBoxNation.Text = "";
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            BusMaker rowToDelete = GridViewHelpers.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList,"");
            using(RejAndOlejContext tempContext = new RejAndOlejContext())
            {
                tempContext.BusMakers.Remove(rowToDelete);
                tempContext.SaveChanges();
            }
            initDataGrid();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = ModelActions.Edit;
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            if (displayList != null && displayList.Count != 0)
            {
                ListPrinter printer = new ListPrinter(displayList);

                printer.Print();
            }
            else
                MessageBox.Show("Brak danych do wydruku!");
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == ModelActions.Edit)
                {
                    var rowToEdit = GridViewHelpers.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList, "");
                    if (textBoxName.Text != "" && textBoxNation.Text != "")
                    {
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            tempContext.Update(rowToEdit);
                            rowToEdit.Name = textBoxName.Text;
                            rowToEdit.Nation = textBoxNation.Text;
                            context.SaveChanges();
                            initDataGrid();
                        }
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
                else if (DBAction == ModelActions.Insert)
                {
                    if (textBoxName.Text != "" && textBoxNation.Text != "")
                    {
                        int busMakerId = context.BusMakers.OrderBy(bm => bm.BusMakerId).Last().BusMakerId + 1;
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            BusMaker rowToInsert = new BusMaker()
                            {
                                BusMakerId = busMakerId,
                                Name = textBoxName.Text,
                                Nation = textBoxNation.Text,
                            };
                            tempContext.BusMakers.Add(rowToInsert);
                            tempContext.SaveChanges();
                        }
                        initDataGrid();
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
            }
        }
    }
}
