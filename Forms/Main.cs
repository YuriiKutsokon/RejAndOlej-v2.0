﻿using RejAndOlej.Helpers.Controls;
using RejAndOlej.UserControls.Autobusy;
using RejAndOlej.UserControls.Flota;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            registerEvents();
        }

        private void registerEvents()
        {
            menuItemBusMakers.Click += (s, e) => CreateTabPage(menuItemBusMakers);
            menuItemBusModels.Click += (s, e) => CreateTabPage(menuItemBusModels);
            menuItemListaPojazdow.Click += (s, e) => CreateTabPage(menuItemListaPojazdow);
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
                }

                userControl.Dock = DockStyle.Fill;
                tabPage.Text = item.Text;
                tabPage.Controls.Add(userControl);
                tabControlInnerForms.TabPages.Add(tabPage);
                tabControlInnerForms.SelectTab(tabPage);
            }
            else
                TabPageHelepr.SelectOpenTab(tabControlInnerForms, item.Tag);
        }

        private void menuItemBusModels_Click(object sender, EventArgs e)
        {
            uc_BusModels bmControl = new uc_BusModels();
            bmControl.Dock = DockStyle.Fill;
            TabPage tabPageBusModels = new TabPage();
            tabPageBusModels.Text = "Modele Autobusów";
            tabPageBusModels.Controls.Add(bmControl);
            tabControlInnerForms.TabPages.Add(tabPageBusModels);
            tabControlInnerForms.SelectTab(tabPageBusModels);
        }

        private void menuItemFlota_Click(object sender, EventArgs e)
        {


        }

        private void menuItemListaPojazdow_Click(object sender, EventArgs e)
        {
            uc_Fleet fleetControl = new uc_Fleet();
            fleetControl.Dock = DockStyle.Fill;
            TabPage tabPageFleet = new TabPage();
            tabPageFleet.Text = "Flota";
            tabPageFleet.Controls.Add(fleetControl);
            tabControlInnerForms.TabPages.Add(tabPageFleet);
            tabControlInnerForms.SelectTab(tabPageFleet);
        }

        private void tabControlInnerForms_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPageHelepr.createTabCloseButton(tabControlInnerForms, e);
        }

        private void tabControlInnerForms_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tabControlInnerForms.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControlInnerForms.Padding = new Point(13, 0);
            openTabsTags = new List<object>();
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
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);
                }
            }

        }
    }
}