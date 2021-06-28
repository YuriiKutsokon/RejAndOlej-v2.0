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

namespace RejAndOlej.UserControls.Autobusy
{
    public partial class uc_BusMakers : UserControl
    {
        public uc_BusMakers()
        {
            InitializeComponent();
            initDataGrid();
        }


        private void initDataGrid()
        {
            List<BusMaker> busMakersList = context.BusMakers.ToList();
            var view = BusMakersMainTAbleView.GetBusMakerViewList(busMakersList);
            dataGridViewBusMakersList.DataSource = view;
        }

        private void buttonNewBusmaker_Click(object sender, EventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Insert;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == (int)DBTableActions.Edit)
                {
                    BusMaker rowToEdit = context.BusMakers.Where(bm => bm.BusMakerId == dataGridViewBusMakersList.CurrentCell.RowIndex).FirstOrDefault();
                    if (textBoxName.Text != "" && textBoxNation.Text != "")
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
                    if (textBoxName.Text != "" && textBoxNation.Text != "")
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

        private void dataGridViewBusMakersList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            groupBoxDataManipulation.Enabled = true;
            DBAction = (int)DBTableActions.Edit;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            BusMaker rowToDelete = context.BusMakers.Where(bm => bm.BusMakerId == dataGridViewBusMakersList.CurrentCell.RowIndex).FirstOrDefault();
            context.BusMakers.Remove(rowToDelete);
            context.SaveChanges();
            initDataGrid();
        }
    }
}
