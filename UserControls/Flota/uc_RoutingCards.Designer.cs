
namespace RejAndOlej.UserControls.Flota
{
    partial class uc_RoutingCards
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
            this.dataGridViewRoutingCardsList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.gbVehicleData = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLeftToNextCheck = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMileage = new System.Windows.Forms.TextBox();
            this.tbModelName = new System.Windows.Forms.TextBox();
            this.tbRegistrationNumber = new System.Windows.Forms.TextBox();
            this.groupBoxRoutingCardData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDriverNumber = new System.Windows.Forms.TextBox();
            this.textBoxMileageOnCard = new System.Windows.Forms.TextBox();
            this.dateTimePickerCardDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutingCardsList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gbVehicleData.SuspendLayout();
            this.groupBoxRoutingCardData.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRoutingCardsList
            // 
            this.dataGridViewRoutingCardsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoutingCardsList.Location = new System.Drawing.Point(-1, 221);
            this.dataGridViewRoutingCardsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRoutingCardsList.Name = "dataGridViewRoutingCardsList";
            this.dataGridViewRoutingCardsList.RowHeadersWidth = 51;
            this.dataGridViewRoutingCardsList.RowTemplate.Height = 29;
            this.dataGridViewRoutingCardsList.Size = new System.Drawing.Size(909, 266);
            this.dataGridViewRoutingCardsList.TabIndex = 17;
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
            this.toolStripButtonSearch,
            this.toolStripButtonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(908, 27);
            this.toolStrip1.TabIndex = 19;
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
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::RejAndOlej.Properties.Resources.Print_256;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonPrint.Text = "toolStripButton1";
            this.toolStripButtonPrint.ToolTipText = "Wydrukuj";
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
            this.gbVehicleData.Location = new System.Drawing.Point(10, 48);
            this.gbVehicleData.Name = "gbVehicleData";
            this.gbVehicleData.Size = new System.Drawing.Size(406, 168);
            this.gbVehicleData.TabIndex = 20;
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
            // labelLeftToNextCheck
            // 
            this.labelLeftToNextCheck.AutoSize = true;
            this.labelLeftToNextCheck.Location = new System.Drawing.Point(47, 127);
            this.labelLeftToNextCheck.Name = "labelLeftToNextCheck";
            this.labelLeftToNextCheck.Size = new System.Drawing.Size(0, 15);
            this.labelLeftToNextCheck.TabIndex = 8;
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
            // groupBoxRoutingCardData
            // 
            this.groupBoxRoutingCardData.Controls.Add(this.dateTimePickerCardDate);
            this.groupBoxRoutingCardData.Controls.Add(this.label1);
            this.groupBoxRoutingCardData.Controls.Add(this.label2);
            this.groupBoxRoutingCardData.Controls.Add(this.label3);
            this.groupBoxRoutingCardData.Controls.Add(this.label7);
            this.groupBoxRoutingCardData.Controls.Add(this.textBoxDriverNumber);
            this.groupBoxRoutingCardData.Controls.Add(this.textBoxMileageOnCard);
            this.groupBoxRoutingCardData.Location = new System.Drawing.Point(422, 48);
            this.groupBoxRoutingCardData.Name = "groupBoxRoutingCardData";
            this.groupBoxRoutingCardData.Size = new System.Drawing.Size(472, 168);
            this.groupBoxRoutingCardData.TabIndex = 21;
            this.groupBoxRoutingCardData.TabStop = false;
            this.groupBoxRoutingCardData.Text = "Dane karty drogowej";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data zgłoszenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stan licznika pojazdu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Numer kierowcy";
            // 
            // textBoxDriverNumber
            // 
            this.textBoxDriverNumber.Location = new System.Drawing.Point(187, 31);
            this.textBoxDriverNumber.Name = "textBoxDriverNumber";
            this.textBoxDriverNumber.ReadOnly = true;
            this.textBoxDriverNumber.Size = new System.Drawing.Size(199, 23);
            this.textBoxDriverNumber.TabIndex = 1;
            // 
            // textBoxMileageOnCard
            // 
            this.textBoxMileageOnCard.Location = new System.Drawing.Point(187, 60);
            this.textBoxMileageOnCard.Name = "textBoxMileageOnCard";
            this.textBoxMileageOnCard.ReadOnly = true;
            this.textBoxMileageOnCard.Size = new System.Drawing.Size(199, 23);
            this.textBoxMileageOnCard.TabIndex = 0;
            // 
            // dateTimePickerCardDate
            // 
            this.dateTimePickerCardDate.Location = new System.Drawing.Point(187, 88);
            this.dateTimePickerCardDate.Name = "dateTimePickerCardDate";
            this.dateTimePickerCardDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerCardDate.TabIndex = 9;
            // 
            // uc_RoutingCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxRoutingCardData);
            this.Controls.Add(this.gbVehicleData);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewRoutingCardsList);
            this.Name = "uc_RoutingCards";
            this.Size = new System.Drawing.Size(908, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoutingCardsList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbVehicleData.ResumeLayout(false);
            this.gbVehicleData.PerformLayout();
            this.groupBoxRoutingCardData.ResumeLayout(false);
            this.groupBoxRoutingCardData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRoutingCardsList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.GroupBox gbVehicleData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLeftToNextCheck;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMileage;
        private System.Windows.Forms.TextBox tbModelName;
        private System.Windows.Forms.TextBox tbRegistrationNumber;
        private System.Windows.Forms.GroupBox groupBoxRoutingCardData;
        private System.Windows.Forms.DateTimePicker dateTimePickerCardDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxDriverNumber;
        private System.Windows.Forms.TextBox textBoxMileageOnCard;
    }
}
