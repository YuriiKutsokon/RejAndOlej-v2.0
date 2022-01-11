using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using RejAndOlej.Enums;
using RejAndOlej.Forms.SearchingTables;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Service;
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
        public uc_Users(User user)
        {
            InitializeComponent();
            context = new RejAndOlejContext();

            currentUser = user;

            comboBoxUserGroup.DataSource = context.UserGroups.ToList();

            updateDataGridView();
            initManipulationControls();
        }

        public User CurrentUser { get => currentUser; }

        private void updateDataGridView()
        {
            //ICollection<User> usersList = context.Users.ToList();
            //List<UsersMainTableView> viewList = TableViewHelpers.GetView<UsersMainTableView>(usersList);
            //dataGridViewUserPermissions.DataSource = viewList;
        }

        private void initManipulationControls()
        {
            if (currentUser != null)
            {
                textBoxName.Text = currentUser.Name;
                textBoxSurname.Text = currentUser.Surname;
                textBoxPosition.Text = currentUser.Position;
                textBoxLogin.Text = currentUser.Login;
                textBoxPassword.Text = currentUser.Password;
                if (currentUser._userGroup != null)
                    comboBoxUserGroup.SelectedIndex = (int)currentUser._userGroup;

            }
            ControlCollection controls = groupBoxUserData.Controls;
            ControlsHelpers.EnableControls(controls, false);
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            ControlCollection controls = groupBoxUserData.Controls;
            DBAction = EnModels.ModelActions.Insert;
            FormHelpers.EnableManipulationControls(DBAction, controls);
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            ControlCollection controls = groupBoxUserData.Controls;
            DBAction = EnModels.ModelActions.Edit;
            FormHelpers.EnableManipulationControls(DBAction, controls);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            if (DBAction != null)
            {
                if (DBAction == EnModels.ModelActions.Edit)
                {
                    if (currentUser != null)
                    {
                        currentUser.Name = textBoxName.Text;
                        currentUser.Surname = textBoxSurname.Text;
                        currentUser.Position = textBoxPosition.Text;
                        currentUser.Login = textBoxLogin.Text;
                        currentUser.Password = textBoxPassword.Text;
                        currentUser._userGroup = comboBoxUserGroup.SelectedIndex;
                        ContextHelpers.SaveModelObject(currentUser);
                    }
                }
                else if (DBAction == EnModels.ModelActions.Insert)
                {
                    int newUserId = context.Users.Count();
                    using (RejAndOlejContext tempContext = new RejAndOlejContext())
                    {
                        User user = new User()
                        {
                            UserId = newUserId,
                            Name = textBoxName.Text,
                            Surname = textBoxSurname.Text,
                            Position = textBoxPosition.Text,
                            Login = textBoxLogin.Text,
                            Password = textBoxPassword.Text,
                            _userGroup = comboBoxUserGroup.SelectedIndex
                        };

                        currentUser = user;

                        tempContext.Users.Add(user);
                        tempContext.SaveChanges();
                    }

                    initManipulationControls();
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                if (MessageBox.Show($"Czy chcesz usunąć użytkownika {currentUser.Name.TrimEnd()} {currentUser.Surname.TrimEnd()} ({currentUser.Login.TrimEnd()})?",
                    "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (context.Users.Count() > 1)
                    {
                        int userID = currentUser.UserId - 1;
                        using (RejAndOlejContext tempContext = new RejAndOlejContext())
                        {
                            tempContext.Remove(currentUser);
                            tempContext.SaveChanges();
                        }
                        currentUser = context.Users.Where(u => u.UserId == userID).FirstOrDefault();
                        initManipulationControls();
                    }
                    else
                        MessageBox.Show("Nie można usunąć ostatniego użytkownika!", "Błąd" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            frm_SearchUsers searchForm = new frm_SearchUsers();

            if (searchForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = searchForm.SearchedUser;
                initManipulationControls();
            }
        }

        private void toolStripButtonPrint_Click(object sender, EventArgs e)
        {
            var userList = context.Users.ToList();
            var viewList = TableViewHelpers.GetView<UsersMainTableView>(userList);

            if (viewList != null && viewList.Count != 0)
            {
                ListPrinter printer = new ListPrinter(viewList);

                printer.Print();
            }
            else
                MessageBox.Show("Brak danych do wydruku!");
        }
    }
}
