﻿
using RejAndOlej.Models;

namespace RejAndOlej.Forms.Tables
{
    partial class FleetVehciclesList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dataGridViewFleetList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFleetList)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dataGridViewFleetList
            // 
            this.dataGridViewFleetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFleetList.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewFleetList.Name = "dataGridViewFleetList";
            this.dataGridViewFleetList.RowTemplate.Height = 25;
            this.dataGridViewFleetList.Size = new System.Drawing.Size(800, 429);
            this.dataGridViewFleetList.TabIndex = 1;
            // 
            // FleetVehciclesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewFleetList);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FleetVehciclesList";
            this.Text = "Lista Pojazdow";
            this.Load += new System.EventHandler(this.FleetVehciclesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFleetList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RejAndOlejContext context = new RejAndOlejContext(); 
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridViewFleetList;
    }
}