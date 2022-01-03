
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
            this.tabControlInnerForms = new System.Windows.Forms.TabControl();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmenuItemAutobusy,
            this.menuItemFlota});
            this.mainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.MdiWindowListItem = this.tmenuItemAutobusy;
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mainMenuStrip.ShowItemToolTips = true;
            this.mainMenuStrip.Size = new System.Drawing.Size(1180, 23);
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
            this.menuItemPrzegladyOlejowe});
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
            // tabControlInnerForms
            // 
            this.tabControlInnerForms.Location = new System.Drawing.Point(270, 23);
            this.tabControlInnerForms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlInnerForms.MaximumSize = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.MinimumSize = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.Name = "tabControlInnerForms";
            this.tabControlInnerForms.SelectedIndex = 0;
            this.tabControlInnerForms.Size = new System.Drawing.Size(909, 487);
            this.tabControlInnerForms.TabIndex = 2;
            this.tabControlInnerForms.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlInnerForms_DrawItem);
            this.tabControlInnerForms.Click += new System.EventHandler(this.tabControlInnerForms_Click);
            this.tabControlInnerForms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControlInnerForms_MouseClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 511);
            this.Controls.Add(this.tabControlInnerForms);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Text = "RejAndOlej";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
    }
}

