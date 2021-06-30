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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNation = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataGridViewBusMakersList = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDataManipulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusMakersList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDataManipulation
            // 
            this.groupBoxDataManipulation.Controls.Add(this.label2);
            this.groupBoxDataManipulation.Controls.Add(this.label1);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxNation);
            this.groupBoxDataManipulation.Controls.Add(this.textBoxName);
            this.groupBoxDataManipulation.Enabled = false;
            this.groupBoxDataManipulation.Location = new System.Drawing.Point(165, 36);
            this.groupBoxDataManipulation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Name = "groupBoxDataManipulation";
            this.groupBoxDataManipulation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDataManipulation.Size = new System.Drawing.Size(590, 134);
            this.groupBoxDataManipulation.TabIndex = 0;
            this.groupBoxDataManipulation.TabStop = false;
            this.groupBoxDataManipulation.Text = "Edytuj Producenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kraj pochodzenia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa";
            // 
            // textBoxNation
            // 
            this.textBoxNation.Location = new System.Drawing.Point(195, 99);
            this.textBoxNation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNation.Name = "textBoxNation";
            this.textBoxNation.Size = new System.Drawing.Size(252, 23);
            this.textBoxNation.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(195, 60);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // dataGridViewBusMakersList
            // 
            this.dataGridViewBusMakersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBusMakersList.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewBusMakersList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBusMakersList.Name = "dataGridViewBusMakersList";
            this.dataGridViewBusMakersList.RowHeadersWidth = 51;
            this.dataGridViewBusMakersList.RowTemplate.Height = 29;
            this.dataGridViewBusMakersList.Size = new System.Drawing.Size(909, 557);
            this.dataGridViewBusMakersList.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonSave,
            this.toolStripButtonDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(909, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::RejAndOlej.Properties.Resources.Add_256;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAdd.Text = "toolStripButtonAdd";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::RejAndOlej.Properties.Resources.Edit_256;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "toolStripButton1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::RejAndOlej.Properties.Resources.Save_256;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton1";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = global::RejAndOlej.Properties.Resources.Delete_256;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelete.Text = "toolStripButton1";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // uc_BusMakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewBusMakersList);
            this.Controls.Add(this.groupBoxDataManipulation);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "uc_BusMakers";
            this.Size = new System.Drawing.Size(909, 487);
            this.groupBoxDataManipulation.ResumeLayout(false);
            this.groupBoxDataManipulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBusMakersList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDataManipulation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridViewBusMakersList;
        private RejAndOlejContext context = new RejAndOlejContext();
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
    }
}
