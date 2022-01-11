using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
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
    public partial class frm_SearchUsers : Form
    {
        public frm_SearchUsers()
        {
            InitializeComponent();

            context = new RejAndOlejContext();
        }

        public User SearchedUser { get => searchedUser; }

        private void frm_SearchUsers_Load(object sender, EventArgs e)
        {
            usersList = context.Users.ToList();
            updateTable();
        }

        private void updateTable()
        {
            if (usersList != null)
            {
                var viewList = TableViewHelpers.GetView<UsersMainTableView>(usersList);
                dataGridViewUsers.DataSource = viewList;
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void GetUser(object sender, EventArgs e)
        {
            DataGridView gridView = dataGridViewUsers;

            searchedUser = GridViewHelpers.GetObjectFromDataGridViewRow<User>(gridView, "RegistrationNumber");
            DialogResult = DialogResult.OK;
        }
    }
}
