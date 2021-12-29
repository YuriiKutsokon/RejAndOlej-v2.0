using RejAndOlej.Models;

namespace RejAndOlej.UserControls.Flota
{
    partial class uc_RegistrationChecks
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDataManipulation = new System.Windows.Forms.GroupBox();
            this.cbSetActualMileageAsMileageOnCheck = new System.Windows.Forms.CheckBox();
            this.dateTimeOilCheck = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMileageOnCheck = new System.Windows.Forms.TextBox();
            this.labelLeftToNextCheck = new System.Windows.Forms.Label();
            this.dataGridViewRegistrationChecksList = new System.Windows.Forms.DataGridView();
            this.gbVehicleData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.tbRegistrationNumber = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBoxDataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrationChecksList)).BeginInit();
            this.gbVehicleData.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStripButtonSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 27);
            this.toolStrip1.TabIndex = 18;
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
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonSearch
            // 
            this.toolStripButtonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSearch.Image = global::RejAndOlej.Properties.Resources.table_128;
            this.toolStripButtonSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSearch.Name = "toolStripButtonSearch";
            this.toolStripButtonSearch.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonSearch.Text = "toolStripButton1";
            this.toolStripButtonSearch.Click += new System.EventHandler(this.toolStripButtonSearch_Click);
            // 
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.cbSetActualMileageAsMileageOnCheck);
            this.groupBoxDataManipulation.Controls.Add(this.dateTimeOilCheck);
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.label1);
            this.groupBoxDataManipulation.Controls.Add(this.tbMileageOnCheck);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(452, 48);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(438, 168);
            this.groupBoxDataManipulation.TabIndex = 17;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Dane przeglądu rejestracyjnego";
            // 
            // cbSetActualMileageAsMileageOnCheck
            // 
            this.cbSetActualMileageAsMileageOnCheck.AutoSize = true;
            this.cbSetActualMileageAsMileageOnCheck.Location = new System.Drawing.Point(13, 102);
            this.cbSetActualMileageAsMileageOnCheck.Name = "cbSetActualMileageAsMileageOnCheck";
            this.cbSetActualMileageAsMileageOnCheck.Size = new System.Drawing.Size(352, 19);
            this.cbSetActualMileageAsMileageOnCheck.TabIndex = 10;
            this.cbSetActualMileageAsMileageOnCheck.Text = "Aktualny stan licznika jako stan licznika na moment przeglądu";
            this.cbSetActualMileageAsMileageOnCheck.UseVisualStyleBackColor = true;
            this.cbSetActualMileageAsMileageOnCheck.CheckedChanged += new System.EventHandler(this.cbSetActualMileageAsMileageOnCheck_CheckedChanged);
            // 
            // dateTimeOilCheck
            // 
            this.dateTimeOilCheck.Location = new System.Drawing.Point(270, 64);
            this.dateTimeOilCheck.Name = "dateTimeOilCheck";
            this.dateTimeOilCheck.Size = new System.Drawing.Size(154, 23);
            this.dateTimeOilCheck.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data przeglądu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stan licznika na moment ostatniego przeglądu";
            // 
            // tbMileageOnCheck
            // 
            this.tbMileageOnCheck.Location = new System.Drawing.Point(270, 34);
            this.tbMileageOnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMileageOnCheck.Name = "tbMileageOnCheck";
            this.tbMileageOnCheck.Size = new System.Drawing.Size(154, 23);
            this.tbMileageOnCheck.TabIndex = 0;
            // 
            // labelLeftToNextCheck
            // 
            this.labelLeftToNextCheck.AutoSize = true;
            this.labelLeftToNextCheck.Location = new System.Drawing.Point(47, 127);
            this.labelLeftToNextCheck.Name = "labelLeftToNextCheck";
            this.labelLeftToNextCheck.Size = new System.Drawing.Size(0, 15);
            this.labelLeftToNextCheck.TabIndex = 8;
            // 
            // dataGridViewRegistrationChecksList
            // 
            this.dataGridViewRegistrationChecksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrationChecksList.Location = new System.Drawing.Point(-1, 221);
            this.dataGridViewRegistrationChecksList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRegistrationChecksList.Name = "dataGridViewRegistrationChecksList";
            this.dataGridViewRegistrationChecksList.RowHeadersWidth = 51;
            this.dataGridViewRegistrationChecksList.RowTemplate.Height = 29;
            this.dataGridViewRegistrationChecksList.Size = new System.Drawing.Size(909, 266);
            this.dataGridViewRegistrationChecksList.TabIndex = 16;
            // 
            // gbVehicleData
            // 
            this.gbVehicleData.Controls.Add(this.label6);
            this.gbVehicleData.Controls.Add(this.labelLeftToNextCheck);
            this.gbVehicleData.Controls.Add(this.label5);
            this.gbVehicleData.Controls.Add(this.label4);
            this.gbVehicleData.Controls.Add(this.tbMileage);
            this.gbVehicleData.Controls.Add(this.tbModelName);
            this.gbVehicleData.Controls.Add(this.tbRegistrationNumber);
            this.gbVehicleData.Location = new System.Drawing.Point(16, 48);
            this.gbVehicleData.Name = "gbVehicleData";
            this.gbVehicleData.Size = new System.Drawing.Size(406, 168);
            this.gbVehicleData.TabIndex = 19;
            this.gbVehicleData.TabStop = false;
            this.gbVehicleData.Text = "Dane pojazdu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aktualny stan licznika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numer rejestracyjny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nazwa modelu";
            // 
            // tbMileage
            // 
            this.tbMileage.Location = new System.Drawing.Point(187, 89);
            this.tbMileage.Name = "tbMileage";
            this.tbMileage.ReadOnly = true;
            this.tbMileage.Size = new System.Drawing.Size(199, 23);
            this.tbMileage.TabIndex = 2;
            // 
            // tbModelName
            // 
            this.tbModelName.Location = new System.Drawing.Point(187, 31);
            this.tbModelName.Name = "tbModelName";
            this.tbModelName.ReadOnly = true;
            this.tbModelName.Size = new System.Drawing.Size(199, 23);
            this.tbModelName.TabIndex = 1;
            // 
            // tbRegistrationNumber
            // 
            this.tbRegistrationNumber.Location = new System.Drawing.Point(187, 60);
            this.tbRegistrationNumber.Name = "tbRegistrationNumber";
            this.tbRegistrationNumber.ReadOnly = true;
            this.tbRegistrationNumber.Size = new System.Drawing.Size(199, 23);
            this.tbRegistrationNumber.TabIndex = 0;
            // 
            // uc_RegistrationChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbVehicleData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Controls.Add(this.dataGridViewRegistrationChecksList);
            this.Name = "uc_RegistrationChecks";
            this.Size = new System.Drawing.Size(908, 487);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrationChecksList)).EndInit();
            this.gbVehicleData.ResumeLayout(false);
            this.gbVehicleData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ControlCollection manipulationControls;
        private RejAndOlejContext context;
        private BusFleet selectedVehicle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.DateTimePicker dateTimeOilCheck;
        private System.Windows.Forms.Label labelLeftToNextCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMileageOnCheck;
        private System.Windows.Forms.DataGridView dataGridViewRegistrationChecksList;
        private System.Windows.Forms.GroupBox gbVehicleData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.TextBox tbModelName;
        private System.Windows.Forms.TextBox tbRegistrationNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.CheckBox cbSetActualMileageAsMileageOnCheck;
        private System.Windows.Forms.Label label;
    }
}
