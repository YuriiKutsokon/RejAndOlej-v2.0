using RejAndOlej.Models;
using RejAndOlej.Helpers.Database;
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

namespace RejAndOlej.UserControls.Autobusy
{
    public partial class uc_BusMakers : BaseUserControl
    {
        public uc_BusMakers() :base("Name")
        {
            InitializeComponent();
            initDataGrid();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
             dataGridViewBusMakersList.RowStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);
             dataGridViewBusMakersList.CellStateChanged += (s, e) => initManipulationControls((int)DBTableActions.Edit);

            toolStripButtonEdit.Click += (s, e) => SetEditMode();
            dataGridViewBusMakersList.DoubleClick += (s, e) => SetEditMode();
        }


        private void initDataGrid()
        {
            List<BusMaker> busMakersList = context.BusMakers.ToList();
            var view = BusMakersMainTAbleView.GetBusMakerViewList(busMakersList);
            dataGridViewBusMakersList.DataSource = view;
        }

        private void SetEditMode()
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
            initManipulationControls(DBAction);
        }

        private void initManipulationControls(int? mode)
        {
            BusMaker busMaker = GridViewHelper.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList, SelectionColumn);

            switch (mode)
            {
                case (int)DBTableActions.Edit:
                    textBoxName.Text = busMaker.Name;
                    textBoxNation.Text = busMaker.Nation;
                    break;

                case (int)DBTableActions.Insert:
                    textBoxName.Text = string.Empty;
                    textBoxNation.Text = string.Empty;
                    break;
            }

        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Insert;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            BusMaker rowToDelete = GridViewHelper.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList, SelectionColumn);
            context.BusMakers.Remove(rowToDelete);
            context.SaveChanges();
            initDataGrid();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == (int)DBTableActions.Edit)
                {
                    BusMaker rowToEdit = GridViewHelper.GetObjectFromDataGridViewRow<BusMaker>(dataGridViewBusMakersList, SelectionColumn);
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        rowToEdit.Name = textBoxName.Text;
                        rowToEdit.Nation = textBoxNation.Text;
                        context.SaveChanges();
                        initDataGrid();
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
                else if (DBAction == (int)DBTableActions.Insert)
                {
                    if (!HasEmptyControl(groupBoxDataManipulation.Controls))
                    {
                        BusMaker rowToInsert = new BusMaker()
                        {
                            BusMakerId = context.BusMakers.OrderBy(bm => bm.BusMakerId).Last().BusMakerId + 1,
                            Name = textBoxName.Text,
                            Nation = textBoxNation.Text
                        };
                        context.BusMakers.Add(rowToInsert);
                        context.SaveChanges();
                        initDataGrid();
                    }
                    else
                        MessageBox.Show("Brak danych do wprowadzenia", "brak danych");
                }
            }
        }
    }
}
