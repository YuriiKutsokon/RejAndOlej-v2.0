using RejAndOlej.Models;
namespace RejAndOlej.UserControls.Autobusy
{
    partial class uc_BusMakers
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
            this.groupBoxDataManipulation = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNation = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewBusmaker = new System.Windows.Forms.Button();
            this.dataGridViewBusMakersList = new System.Windows.Forms.DataGridView();
            this.groupBoxDataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusMakersList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.buttonCancel);
            this.groupBoxDataManipulation.Controls.Add(this.buttonSave);
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.label1);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxNation);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxName);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(164, 14);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(590, 143);
            this.groupBoxDataManipulation.TabIndex = 0;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Edytuj Producenta";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(192, 117);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 22);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cofnij";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(362, 117);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 22);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kraj pochodzenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa";
            // 
            // textBoxNation
            // 
            this.textBoxNation.Location = new System.Drawing.Point(192, 73);
            this.textBoxNation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNation.Name = "textBoxNation";
            this.textBoxNation.Size = new System.Drawing.Size(252, 23);
            this.textBoxNation.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(192, 34);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::RejAndOlej.Properties.Resources.Delete_256;
            this.buttonDelete.Location = new System.Drawing.Point(60, 85);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 22);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewBusmaker
            // 
            this.buttonNewBusmaker.Location = new System.Drawing.Point(60, 47);
            this.buttonNewBusmaker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNewBusmaker.Name = "buttonNewBusmaker";
            this.buttonNewBusmaker.Size = new System.Drawing.Size(82, 22);
            this.buttonNewBusmaker.TabIndex = 6;
            this.buttonNewBusmaker.Text = "Nowy";
            this.buttonNewBusmaker.UseVisualStyleBackColor = true;
            this.buttonNewBusmaker.Click += new System.EventHandler(this.buttonNewBusmaker_Click);
            // 
            // dataGridViewBusMakersList
            // 
            this.dataGridViewBusMakersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusMakersList.Location = new System.Drawing.Point(-10, 173);
            this.dataGridViewBusMakersList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBusMakersList.Name = "dataGridViewBusMakersList";
            this.dataGridViewBusMakersList.RowHeadersWidth = 51;
            this.dataGridViewBusMakersList.RowTemplate.Height = 29;
            this.dataGridViewBusMakersList.Size = new System.Drawing.Size(909, 314);
            this.dataGridViewBusMakersList.TabIndex = 1;
            this.dataGridViewBusMakersList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewBusMakersList_CellMouseDoubleClick);
            // 
            // uc_BusMakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.dataGridViewBusMakersList);
            this.Controls.Add(this.buttonNewBusmaker);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_BusMakers";
            this.Size = new System.Drawing.Size(909, 487);
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusMakersList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewBusMakersList;
        private System.Windows.Forms.Button buttonNewBusmaker;
        private System.Windows.Forms.Button buttonDelete;
        private RejAndOlejContext context = new RejAndOlejContext();
        private int? DBAction = null;
    }
}
