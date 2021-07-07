
using RejAndOlej.Models;

namespace RejAndOlej.UserControls.Flota
{
    partial class uc_OilChecks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOilChecksList = new System.Windows.Forms.DataGridView();
            this.groupBoxDataManipulation = new System.Windows.Forms.GroupBox();
            this.dateTimeOilCheck = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxActualMileage = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsddButtonTables = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemFlaota = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOilChecksList)).BeginInit();
            this.groupBoxDataManipulation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOilChecksList
            // 
            this.dataGridViewOilChecksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOilChecksList.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewOilChecksList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOilChecksList.Name = "dataGridViewOilChecksList";
            this.dataGridViewOilChecksList.RowHeadersWidth = 51;
            this.dataGridViewOilChecksList.RowTemplate.Height = 29;
            this.dataGridViewOilChecksList.Size = new System.Drawing.Size(909, 557);
            this.dataGridViewOilChecksList.TabIndex = 2;
            // 
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.dateTimeOilCheck);
            this.groupBoxDataManipulation.Controls.Add(this.label3);
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxActualMileage);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(281, 59);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(345, 95);
            this.groupBoxDataManipulation.TabIndex = 14;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Edytuj przegląd olejowy";
            // 
            // dateTimeOilCheck
            // 
            this.dateTimeOilCheck.Location = new System.Drawing.Point(147, 53);
            this.dateTimeOilCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeOilCheck.Name = "dateTimeOilCheck";
            this.dateTimeOilCheck.Size = new System.Drawing.Size(154, 23);
            this.dateTimeOilCheck.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aktualny przebieg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data przeglądu";
            // 
            // textBoxActualMileage
            // 
            this.textBoxActualMileage.Location = new System.Drawing.Point(147, 20);
            this.textBoxActualMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxActualMileage.Name = "textBoxActualMileage";
            this.textBoxActualMileage.Size = new System.Drawing.Size(154, 23);
            this.textBoxActualMileage.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonSave,
            this.toolStripButtonDelete,
            this.toolStripSeparator1,
            this.tsddButtonTables});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::RejAndOlej.Properties.Resources.Add_256;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonAdd.Text = "Dodaj";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::RejAndOlej.Properties.Resources.Edit_256;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonEdit.Text = "toolStripButton5";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::RejAndOlej.Properties.Resources.Save_256;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSave.Text = "toolStripButton6";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::RejAndOlej.Properties.Resources.Delete_256;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonDelete.Text = "toolStripButton7";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsddButtonTables
            // 
            this.tsddButtonTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsddButtonTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFlaota});
            this.tsddButtonTables.Image = global::RejAndOlej.Properties.Resources.table_256;
            this.tsddButtonTables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddButtonTables.Name = "tsddButtonTables";
            this.tsddButtonTables.Size = new System.Drawing.Size(33, 24);
            this.tsddButtonTables.Text = "toolStripDropDownButton1";
            // 
            // toolStripMenuItemFlaota
            // 
            this.toolStripMenuItemFlaota.Name = "toolStripMenuItemFlaota";
            this.toolStripMenuItemFlaota.Size = new System.Drawing.Size(154, 22);
            this.toolStripMenuItemFlaota.Text = "Flota pojazdów";
            this.toolStripMenuItemFlaota.Click += new System.EventHandler(this.toolStripMenuItemFlaota_Click);
            // 
            // uc_OilChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Controls.Add(this.dataGridViewOilChecksList);
            this.MaximumSize = new System.Drawing.Size(909, 487);
            this.MinimumSize = new System.Drawing.Size(909, 487);
            this.Name = "uc_OilChecks";
            this.Size = new System.Drawing.Size(909, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOilChecksList)).EndInit();
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOilChecksList;
        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.DateTimePicker dateTimeOilCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxActualMileage;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private RejAndOlejContext context = new RejAndOlejContext();
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsddButtonTables;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFlaota;
    }
}
