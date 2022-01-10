using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using RejAndOlej.Helpers;
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

namespace RejAndOlej.UserControls.Users
{
    public partial class uc_Users : BaseUserControl
    {
        public uc_Users()
        {
            InitializeComponent();
            context = new RejAndOlejContext();

            updateDataGridView();
        }

        private void updateDataGridView()
        {
            ICollection<User> usersList = context.Users.ToList();
            List<UsersMainTableView> viewList = TableViewHelpers.GetView<UsersMainTableView>(usersList);
            dataGridViewUsers.DataSource = viewList;
        }
    }
}
