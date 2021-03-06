
using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RejAndOlej
{
    partial class frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tmenuItemAutobusy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBusMakers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBusModels = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFlota = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemListaPojazdow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrzegladyRejestracyjne = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrzegladyOlejowe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMainUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlInnerForms = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCheckDeadlines = new System.Windows.Forms.TabControl();
            this.tabPageOilChecks = new System.Windows.Forms.TabPage();
            this.dataGridViewOilCheckDeadlines = new System.Windows.Forms.DataGridView();
            this.tabPageRegistrationChecks = new System.Windows.Forms.TabPage();
            this.dataGridViewRegistrationChecksDeadlines = new System.Windows.Forms.DataGridView();
            this.menuItemRoutingCards = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.tabControlCheckDeadlines.SuspendLayout();
            this.tabPageOilChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOilCheckDeadlines)).BeginInit();
            this.tabPageRegistrationChecks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrationChecksDeadlines)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmenuItemAutobusy,
            this.menuItemFlota,
            this.menuItemMainUsers});
            this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.tmenuItemAutobusy;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.ShowItemToolTips = true;
            this.mainMenuStrip.Size = new System.Drawing.Size(1306, 23);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "MainMenu";
            // 
            // tmenuItemAutobusy
            // 
            this.tmenuItemAutobusy.CheckOnClick = true;
            this.tmenuItemAutobusy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBusMakers,
            this.menuItemBusModels});
            this.tmenuItemAutobusy.Name = "tmenuItemAutobusy";
            this.tmenuItemAutobusy.Size = new System.Drawing.Size(70, 19);
            this.tmenuItemAutobusy.Text = "Autobusy";
            // 
            // menuItemBusMakers
            // 
            this.menuItemBusMakers.CheckOnClick = true;
            this.menuItemBusMakers.Name = "menuItemBusMakers";
            this.menuItemBusMakers.Size = new System.Drawing.Size(134, 22);
            this.menuItemBusMakers.Tag = "BusMakers";
            this.menuItemBusMakers.Text = "Producenci";
            // 
            // menuItemBusModels
            // 
            this.menuItemBusModels.Name = "menuItemBusModels";
            this.menuItemBusModels.Size = new System.Drawing.Size(134, 22);
            this.menuItemBusModels.Tag = "BusModels";
            this.menuItemBusModels.Text = "Modele";
            // 
            // menuItemFlota
            // 
            this.menuItemFlota.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemListaPojazdow,
            this.menuItemPrzegladyRejestracyjne,
            this.menuItemPrzegladyOlejowe,
            this.menuItemRoutingCards});
            this.menuItemFlota.Name = "menuItemFlota";
            this.menuItemFlota.Size = new System.Drawing.Size(45, 19);
            this.menuItemFlota.Text = "Flota";
            // 
            // menuItemListaPojazdow
            // 
            this.menuItemListaPojazdow.Name = "menuItemListaPojazdow";
            this.menuItemListaPojazdow.Size = new System.Drawing.Size(197, 22);
            this.menuItemListaPojazdow.Tag = "Fleet";
            this.menuItemListaPojazdow.Text = "Lista Pojazdów";
            // 
            // menuItemPrzegladyRejestracyjne
            // 
            this.menuItemPrzegladyRejestracyjne.Name = "menuItemPrzegladyRejestracyjne";
            this.menuItemPrzegladyRejestracyjne.Size = new System.Drawing.Size(197, 22);
            this.menuItemPrzegladyRejestracyjne.Tag = "RegistrationChecks";
            this.menuItemPrzegladyRejestracyjne.Text = "Przeglądy Rejestracyjne";
            // 
            // menuItemPrzegladyOlejowe
            // 
            this.menuItemPrzegladyOlejowe.Name = "menuItemPrzegladyOlejowe";
            this.menuItemPrzegladyOlejowe.Size = new System.Drawing.Size(197, 22);
            this.menuItemPrzegladyOlejowe.Tag = "OilChecks";
            this.menuItemPrzegladyOlejowe.Text = "Przeglądy Olejowe";
            // 
            // menuItemMainUsers
            // 
            this.menuItemMainUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemUser});
            this.menuItemMainUsers.Name = "menuItemMainUsers";
            this.menuItemMainUsers.Size = new System.Drawing.Size(86, 19);
            this.menuItemMainUsers.Text = "Użytkownicy";
            // 
            // menuItemUser
            // 
            this.menuItemUser.Name = "menuItemUser";
            this.menuItemUser.Size = new System.Drawing.Size(135, 22);
            this.menuItemUser.Tag = "User";
            this.menuItemUser.Text = "Użytkownik";
            // 
            // tabControlInnerForms
            // 
            this.tabControlInnerForms.Location = new System.Drawing.Point(384, 35);
            this.tabControlInnerForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInnerForms.MaximumSize = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.MinimumSize = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.Name = "tabControlInnerForms";
            this.tabControlInnerForms.SelectedIndex = 0;
            this.tabControlInnerForms.Size = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.TabIndex = 2;
            this.tabControlInnerForms.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlInnerForms_DrawItem);
            this.tabControlInnerForms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlInnerForms_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pojazdy ze zbliżającymi się lub przeterminowanymi przeglądami ";
            // 
            // tabControlCheckDeadlines
            // 
            this.tabControlCheckDeadlines.Controls.Add(this.tabPageOilChecks);
            this.tabControlCheckDeadlines.Controls.Add(this.tabPageRegistrationChecks);
            this.tabControlCheckDeadlines.Location = new System.Drawing.Point(12, 65);
            this.tabControlCheckDeadlines.Name = "tabControlCheckDeadlines";
            this.tabControlCheckDeadlines.SelectedIndex = 0;
            this.tabControlCheckDeadlines.Size = new System.Drawing.Size(366, 457);
            this.tabControlCheckDeadlines.TabIndex = 5;
            // 
            // tabPageOilChecks
            // 
            this.tabPageOilChecks.Controls.Add(this.dataGridViewOilCheckDeadlines);
            this.tabPageOilChecks.Location = new System.Drawing.Point(4, 24);
            this.tabPageOilChecks.Name = "tabPageOilChecks";
            this.tabPageOilChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOilChecks.Size = new System.Drawing.Size(358, 429);
            this.tabPageOilChecks.TabIndex = 0;
            this.tabPageOilChecks.Text = "Przeglądy olejowe";
            this.tabPageOilChecks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOilCheckDeadlines
            // 
            this.dataGridViewOilCheckDeadlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOilCheckDeadlines.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewOilCheckDeadlines.Name = "dataGridViewOilCheckDeadlines";
            this.dataGridViewOilCheckDeadlines.RowTemplate.Height = 25;
            this.dataGridViewOilCheckDeadlines.Size = new System.Drawing.Size(352, 423);
            this.dataGridViewOilCheckDeadlines.TabIndex = 0;
            this.dataGridViewOilCheckDeadlines.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewOilCheckDeadlines_Paint);
            // 
            // tabPageRegistrationChecks
            // 
            this.tabPageRegistrationChecks.Controls.Add(this.dataGridViewRegistrationChecksDeadlines);
            this.tabPageRegistrationChecks.Location = new System.Drawing.Point(4, 24);
            this.tabPageRegistrationChecks.Name = "tabPageRegistrationChecks";
            this.tabPageRegistrationChecks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrationChecks.Size = new System.Drawing.Size(358, 429);
            this.tabPageRegistrationChecks.TabIndex = 1;
            this.tabPageRegistrationChecks.Text = "Przeglądy rejestracyjne";
            this.tabPageRegistrationChecks.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRegistrationChecksDeadlines
            // 
            this.dataGridViewRegistrationChecksDeadlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrationChecksDeadlines.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewRegistrationChecksDeadlines.Name = "dataGridViewRegistrationChecksDeadlines";
            this.dataGridViewRegistrationChecksDeadlines.RowTemplate.Height = 25;
            this.dataGridViewRegistrationChecksDeadlines.Size = new System.Drawing.Size(352, 423);
            this.dataGridViewRegistrationChecksDeadlines.TabIndex = 0;
            this.dataGridViewRegistrationChecksDeadlines.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewRegistrationChecksDeadlines_Paint);
            // 
            // menuItemRoutingCards
            // 
            this.menuItemRoutingCards.Name = "menuItemRoutingCards";
            this.menuItemRoutingCards.Size = new System.Drawing.Size(197, 22);
            this.menuItemRoutingCards.Tag = "RoutingCards";
            this.menuItemRoutingCards.Text = "Karty Drogowe";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 684);
            this.Controls.Add(this.tabControlCheckDeadlines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlInnerForms);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Main";
            this.Text = "RejAndOlej";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.tabControlCheckDeadlines.ResumeLayout(false);
            this.tabPageOilChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOilCheckDeadlines)).EndInit();
            this.tabPageRegistrationChecks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrationChecksDeadlines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private User currentUser;
        private RejAndOlejContext context;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tmenuItemAutobusy;
        private System.Windows.Forms.ToolStripMenuItem menuItemBusMakers;
        private System.Windows.Forms.ToolStripMenuItem menuItemBusModels;
        private System.Windows.Forms.ToolStripMenuItem menuItemFlota;
        private System.Windows.Forms.ToolStripMenuItem menuItemListaPojazdow;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrzegladyRejestracyjne;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrzegladyOlejowe;
        private System.Windows.Forms.TabControl tabControlInnerForms;
        private List<object> openTabsTags;
        private Label label1;
        private TabControl tabControlCheckDeadlines;
        private TabPage tabPageOilChecks;
        private DataGridView dataGridViewOilCheckDeadlines;
        private TabPage tabPageRegistrationChecks;
        private DataGridView dataGridViewRegistrationChecksDeadlines;
        private ToolStripMenuItem menuItemMainUsers;
        private ToolStripMenuItem menuItemUser;
        private ToolStripMenuItem menuItemRoutingCards;
    }
}

