
using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using RejAndOlej.Forms;
using RejAndOlej.Helpers;
using RejAndOlej.Helpers.Controls;
using RejAndOlej.Models;
using RejAndOlej.UserControls.Autobusy;
using RejAndOlej.UserControls.Flota;
using RejAndOlej.UserControls.Users;
using RejAndOlej.Views.TableViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
            registerEvents();

            context = new RejAndOlejContext();
            updateDataGridViews();
        }

        private void registerEvents()
        {
            menuItemBusMakers.Click += (s, e) => CreateTabPage(menuItemBusMakers);
            menuItemBusModels.Click += (s, e) => CreateTabPage(menuItemBusModels);
            menuItemListaPojazdow.Click += (s, e) => CreateTabPage(menuItemListaPojazdow);
            menuItemPrzegladyOlejowe.Click += (s, e) => CreateTabPage(menuItemPrzegladyOlejowe);
            menuItemPrzegladyRejestracyjne.Click += (s, e) => CreateTabPage(menuItemPrzegladyRejestracyjne);
            menuItemUser.Click += (s, e) => CreateTabPage(menuItemUser);
            menuItemRoutingCards.Click += (s, e) => CreateTabPage(menuItemRoutingCards);
        }

        public User CurrentUser { get => currentUser; }

        public void updateDataGridViews()
        {
            ICollection<BusFleet> listOilVehicles = context.BusFleets.Where(v => v.OilCheckStatus == Enums.EnChecks.CheckStatuses.NotValid ||
                v.OilCheckStatus == Enums.EnChecks.CheckStatuses.Nearby).ToList();
            dataGridViewOilCheckDeadlines.DataSource = TableViewHelpers.GetView<FleetMainTableView>(listOilVehicles);

            ICollection<BusFleet> listRegVehicles = context.BusFleets.Where(v => v.RegCheckStatus == Enums.EnChecks.CheckStatuses.NotValid ||
                v.RegCheckStatus == Enums.EnChecks.CheckStatuses.Nearby).ToList();
            dataGridViewRegistrationChecksDeadlines.DataSource = TableViewHelpers.GetView<FleetMainTableView>(listRegVehicles);
        }

        private void CreateTabPage(ToolStripMenuItem item)
        {
            UserControl userControl = null;
            string controlType = item.Tag.ToString();
            if (!openTabsTags.Contains(item.Tag))
            {
                TabPage tabPage = new TabPage();
                tabPage.Tag = item.Tag;
                switch (controlType)
                {
                    case "BusMakers":
                        userControl = new uc_BusMakers();
                        openTabsTags.Add(item.Tag);
                        break;
                    case "BusModels":
                        userControl = new uc_BusModels();
                        openTabsTags.Add(item.Tag);
                        break;
                    case "Fleet":
                        userControl = new uc_Fleet();
                        openTabsTags.Add(item.Tag);
                        break;
                    case "OilChecks":
                        userControl = new uc_OilChecks();
                        openTabsTags.Add(item.Tag);
                        break;
                    case "RegistrationChecks":
                        userControl = new uc_RegistrationChecks();
                        openTabsTags.Add(item.Tag);
                        break;
                    case "User":
                        userControl = new uc_Users(CurrentUser);
                        openTabsTags.Add(item.Tag);
                        break;
                    case "RoutingCards":
                        userControl = new uc_RoutingCards();
                        openTabsTags.Add(item.Tag);
                        break;
                }

                userControl.Dock = DockStyle.Fill;
                tabPage.Text = item.Text;
                tabPage.Controls.Add(userControl);
                tabControlInnerForms.TabPages.Add(tabPage);
                tabControlInnerForms.SelectTab(tabPage);
            }
            else
                TabPageHeleprs.SelectOpenTab(tabControlInnerForms, item.Tag);
        }

        private void tabControlInnerForms_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPageHeleprs.createTabCloseButton(tabControlInnerForms, e);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frm_Login loginForm = new frm_Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                tabControlInnerForms.DrawMode = TabDrawMode.OwnerDrawFixed;
                tabControlInnerForms.Padding = new Point(13, 0);
                openTabsTags = new List<object>();
                currentUser = loginForm.LoginUser;
                this.Text = $"Rej&Olej | {currentUser.Name.TrimEnd()} {currentUser.Surname.TrimEnd()} ({currentUser.Login.TrimEnd()})";
            }
            else
                this.Close();

            loginForm.Close();

        }

        private void tabControlInnerForms_MouseClick(object sender, MouseEventArgs e)
        {
            Point _imgHitArea = new Point(13, 2);
            TabControl tc = (TabControl)sender;
            int _tabWidth = this.tabControlInnerForms.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControlInnerForms.GetTabRect(tc.SelectedIndex);
            Point p = e.Location;
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControlInnerForms.SelectedIndex >= 0)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);

                    if (openTabsTags.Contains(TabP.Tag))
                    {
                        openTabsTags.Remove(TabP.Tag);
                    }
                }
            }

        }

        private void dataGridViewOilCheckDeadlines_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < dataGridViewOilCheckDeadlines.RowCount; i++)
            {
                var oilChecksView = dataGridViewOilCheckDeadlines.DataSource as ICollection<FleetMainTableView>;
                List<BusFleet> oilChecks = (List<BusFleet>)TableViewHelpers.GetModelObjectList(oilChecksView);

                if (oilChecks != null)
                {
                    if (oilChecks[i].OilCheckStatus == Enums.EnChecks.CheckStatuses.NotValid)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.Salmon;
                        dataGridViewOilCheckDeadlines.Rows[i].DefaultCellStyle = style;
                    }
                    else if (oilChecks[i].OilCheckStatus == Enums.EnChecks.CheckStatuses.Nearby)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.Orange;
                        dataGridViewOilCheckDeadlines.Rows[i].DefaultCellStyle = style;
                    }
                }
            }
        }

        private void dataGridViewRegistrationChecksDeadlines_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < dataGridViewRegistrationChecksDeadlines.RowCount; i++)
            {
                var regChecksView = dataGridViewRegistrationChecksDeadlines.DataSource as ICollection<FleetMainTableView>;
                List<BusFleet> regChecks = (List<BusFleet>)TableViewHelpers.GetModelObjectList(regChecksView);

                if (regChecks != null)
                {
                    if (regChecks[i].RegCheckStatus == Enums.EnChecks.CheckStatuses.NotValid)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.Salmon;
                        dataGridViewRegistrationChecksDeadlines.Rows[i].DefaultCellStyle = style;
                    }
                    else if (regChecks[i].RegCheckStatus == Enums.EnChecks.CheckStatuses.Nearby)
                    {
                        DataGridViewCellStyle style = new DataGridViewCellStyle();
                        style.BackColor = Color.Orange;
                        dataGridViewRegistrationChecksDeadlines.Rows[i].DefaultCellStyle = style;
                    }
                }
            }
        }
    }
}
