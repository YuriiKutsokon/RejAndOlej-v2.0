
using RejAndOlej.Models;

namespace RejAndOlej.Forms.CreationForms
{
    partial class frm_AddCheck
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxMileage = new System.Windows.Forms.TextBox();
            this.dateTimeOnCheck = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCheckType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSetMileageOnCheckAsVehicleMileage = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Image = global::RejAndOlej.Properties.Resources.OKButton_16;
            this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOK.Location = new System.Drawing.Point(289, 173);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(91, 26);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::RejAndOlej.Properties.Resources.CancelButton_16;
            this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancel.Location = new System.Drawing.Point(192, 173);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 26);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxMileage
            // 
            this.textBoxMileage.Location = new System.Drawing.Point(192, 65);
            this.textBoxMileage.Name = "textBoxMileage";
            this.textBoxMileage.Size = new System.Drawing.Size(165, 23);
            this.textBoxMileage.TabIndex = 2;
            // 
            // dateTimeOnCheck
            // 
            this.dateTimeOnCheck.Location = new System.Drawing.Point(192, 94);
            this.dateTimeOnCheck.Name = "dateTimeOnCheck";
            this.dateTimeOnCheck.Size = new System.Drawing.Size(164, 23);
            this.dateTimeOnCheck.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Przebieg na moment przeglądu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data przeglądu";
            // 
            // comboBoxCheckType
            // 
            this.comboBoxCheckType.FormattingEnabled = true;
            this.comboBoxCheckType.Items.AddRange(new object[] {
            "Przegląd olejowy",
            "Przegląd rejestracyjny"});
            this.comboBoxCheckType.Location = new System.Drawing.Point(192, 36);
            this.comboBoxCheckType.Name = "comboBoxCheckType";
            this.comboBoxCheckType.Size = new System.Drawing.Size(164, 23);
            this.comboBoxCheckType.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rodzaj przeglądu";
            // 
            // checkBoxSetMileageOnCheckAsVehicleMileage
            // 
            this.checkBoxSetMileageOnCheckAsVehicleMileage.AutoSize = true;
            this.checkBoxSetMileageOnCheckAsVehicleMileage.Location = new System.Drawing.Point(12, 135);
            this.checkBoxSetMileageOnCheckAsVehicleMileage.Name = "checkBoxSetMileageOnCheckAsVehicleMileage";
            this.checkBoxSetMileageOnCheckAsVehicleMileage.Size = new System.Drawing.Size(327, 19);
            this.checkBoxSetMileageOnCheckAsVehicleMileage.TabIndex = 8;
            this.checkBoxSetMileageOnCheckAsVehicleMileage.Text = "Ustawić stan licznika na moment przeglądu jako aktualny";
            this.checkBoxSetMileageOnCheckAsVehicleMileage.UseVisualStyleBackColor = true;
            // 
            // frm_AddCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 211);
            this.Controls.Add(this.checkBoxSetMileageOnCheckAsVehicleMileage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCheckType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeOnCheck);
            this.Controls.Add(this.textBoxMileage);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "frm_AddCheck";
            this.Text = "Dodaj nowy przegląd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OilCheck newOilCheck;
        private RegistrationCheck newRegistrationChaeck;
        private BusFleet _bus;
        private Enums.EnChecks.CheckTypes _checkType;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxMileage;
        private System.Windows.Forms.DateTimePicker dateTimeOnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCheckType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSetMileageOnCheckAsVehicleMileage;
    }
}