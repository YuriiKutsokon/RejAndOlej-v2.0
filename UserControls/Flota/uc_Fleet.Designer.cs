
using RejAndOlej.Models;

namespace RejAndOlej.UserControls.Flota
{
    partial class uc_Fleet
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDataManipulation = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBusMakerModels = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeEnterToFleet = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxBusMaker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRegNum = new System.Windows.Forms.TextBox();
            this.textBoxracNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewModelsList = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBoxDataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelsList)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.TabIndex = 14;
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
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.label6);
            this.groupBoxDataManipulation.Controls.Add(this.comboBoxBusMakerModels);
            this.groupBoxDataManipulation.Controls.Add(this.label5);
            this.groupBoxDataManipulation.Controls.Add(this.dateTimeEnterToFleet);
            this.groupBoxDataManipulation.Controls.Add(this.label4);
            this.groupBoxDataManipulation.Controls.Add(this.comboBoxBusMaker);
            this.groupBoxDataManipulation.Controls.Add(this.label3);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxMileage);
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.label1);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxRegNum);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxracNumber);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(118, 40);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(638, 144);
            this.groupBoxDataManipulation.TabIndex = 13;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Edytuj pojazd floty autobusów";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Producent";
            // 
            // comboBoxBusMakerModels
            // 
            this.comboBoxBusMakerModels.FormattingEnabled = true;
            this.comboBoxBusMakerModels.Location = new System.Drawing.Point(452, 68);
            this.comboBoxBusMakerModels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBusMakerModels.Name = "comboBoxBusMakerModels";
            this.comboBoxBusMakerModels.Size = new System.Drawing.Size(164, 23);
            this.comboBoxBusMakerModels.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data przyjęcia do floty";
            // 
            // dateTimeEnterToFleet
            // 
            this.dateTimeEnterToFleet.Location = new System.Drawing.Point(452, 97);
            this.dateTimeEnterToFleet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeEnterToFleet.Name = "dateTimeEnterToFleet";
            this.dateTimeEnterToFleet.Size = new System.Drawing.Size(164, 23);
            this.dateTimeEnterToFleet.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Model";
            // 
            // comboBoxBusMaker
            // 
            this.comboBoxBusMaker.FormattingEnabled = true;
            this.comboBoxBusMaker.Location = new System.Drawing.Point(452, 37);
            this.comboBoxBusMaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBusMaker.Name = "comboBoxBusMaker";
            this.comboBoxBusMaker.Size = new System.Drawing.Size(164, 23);
            this.comboBoxBusMaker.TabIndex = 9;
            this.comboBoxBusMaker.SelectedIndexChanged += new System.EventHandler(this.comboBoxBusMaker_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numer Rejestracyjny";
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(144, 97);
            this.textBoxMileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(154, 23);
            this.textBoxMileage.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przebieg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numer Taborowy";
            // 
            // textBoxRegNum
            // 
            this.textBoxRegNum.Location = new System.Drawing.Point(144, 68);
            this.textBoxRegNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxRegNum.Name = "textBoxRegNum";
            this.textBoxRegNum.Size = new System.Drawing.Size(154, 23);
            this.textBoxRegNum.TabIndex = 1;
            // 
            // textBoxracNumber
            // 
            this.textBoxracNumber.Location = new System.Drawing.Point(144, 38);
            this.textBoxracNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxracNumber.Name = "textBoxracNumber";
            this.textBoxracNumber.Size = new System.Drawing.Size(154, 23);
            this.textBoxracNumber.TabIndex = 0;
            // 
            // dataGridViewModelsList
            // 
            this.dataGridViewModelsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModelsList.Location = new System.Drawing.Point(0, 188);
            this.dataGridViewModelsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewModelsList.Name = "dataGridViewModelsList";
            this.dataGridViewModelsList.RowHeadersWidth = 51;
            this.dataGridViewModelsList.RowTemplate.Height = 29;
            this.dataGridViewModelsList.Size = new System.Drawing.Size(909, 299);
            this.dataGridViewModelsList.TabIndex = 12;
            // 
            // uc_Fleet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Controls.Add(this.dataGridViewModelsList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_Fleet";
            this.Size = new System.Drawing.Size(909, 487);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModelsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeEnterToFleet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxBusMaker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRegNum;
        private System.Windows.Forms.TextBox textBoxracNumber;
        private System.Windows.Forms.DataGridView dataGridViewModelsList;
        private RejAndOlejContext context = new RejAndOlejContext();
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBusMakerModels;
    }
}
