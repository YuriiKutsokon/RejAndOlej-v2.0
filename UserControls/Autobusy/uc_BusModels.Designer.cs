
using RejAndOlej.Models;

namespace RejAndOlej.UserControls.Autobusy
{
    partial class uc_BusModels
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewModelsList = new System.Windows.Forms.DataGridView();
            this.groupBoxDataManipulation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBusMaker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKmToOilCheck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDaysToCheck = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelsList)).BeginInit();
            this.groupBoxDataManipulation.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewModelsList
            // 
            this.dataGridViewModelsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModelsList.Location = new System.Drawing.Point(2, 189);
            this.dataGridViewModelsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewModelsList.Name = "dataGridViewModelsList";
            this.dataGridViewModelsList.RowHeadersWidth = 51;
            this.dataGridViewModelsList.RowTemplate.Height = 29;
            this.dataGridViewModelsList.Size = new System.Drawing.Size(909, 457);
            this.dataGridViewModelsList.TabIndex = 2;
            // 
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.label4);
            this.groupBoxDataManipulation.Controls.Add(this.comboBoxBusMaker);
            this.groupBoxDataManipulation.Controls.Add(this.label3);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxKmToOilCheck);
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.label1);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxDaysToCheck);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxName);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(120, 41);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(638, 143);
            this.groupBoxDataManipulation.TabIndex = 8;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Edytuj Model Autobusu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Domyślny krok przeglądu Olejowego, km";
            // 
            // comboBoxBusMaker
            // 
            this.comboBoxBusMaker.FormattingEnabled = true;
            this.comboBoxBusMaker.Location = new System.Drawing.Point(24, 114);
            this.comboBoxBusMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBusMaker.Name = "comboBoxBusMaker";
            this.comboBoxBusMaker.Size = new System.Drawing.Size(252, 23);
            this.comboBoxBusMaker.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Producent";
            // 
            // textBoxKmToOilCheck
            // 
            this.textBoxKmToOilCheck.Location = new System.Drawing.Point(362, 114);
            this.textBoxKmToOilCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKmToOilCheck.Name = "textBoxKmToOilCheck";
            this.textBoxKmToOilCheck.Size = new System.Drawing.Size(252, 23);
            this.textBoxKmToOilCheck.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zakres przeglądu technicznego";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa";
            // 
            // textBoxDaysToCheck
            // 
            this.textBoxDaysToCheck.Location = new System.Drawing.Point(362, 58);
            this.textBoxDaysToCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDaysToCheck.Name = "textBoxDaysToCheck";
            this.textBoxDaysToCheck.Size = new System.Drawing.Size(252, 23);
            this.textBoxDaysToCheck.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(24, 58);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonSave,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 27);
            this.toolStrip1.TabIndex = 11;
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
            // uc_BusModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Controls.Add(this.dataGridViewModelsList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(909, 487);
            this.MinimumSize = new System.Drawing.Size(909, 487);
            this.Name = "uc_BusModels";
            this.Size = new System.Drawing.Size(909, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelsList)).EndInit();
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModelsList;
        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDaysToCheck;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKmToOilCheck;
        private System.Windows.Forms.ComboBox comboBoxBusMaker;
        RejAndOlejContext context = new RejAndOlejContext();
        private int? DBAction = null;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}
