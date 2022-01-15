
using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;

namespace RejAndOlej.UserControls.Users
{
    partial class uc_Users
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
            this.dataGridViewUserPermissions = new System.Windows.Forms.DataGridView();
            this.groupBoxUserData = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUserGroup = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxUserGroup = new System.Windows.Forms.GroupBox();
            this.buttonDeleteUserGroup = new System.Windows.Forms.Button();
            this.buttonSaveUserGroup = new System.Windows.Forms.Button();
            this.buttonEditUserGroup = new System.Windows.Forms.Button();
            this.buttonAddNewUserGroup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserGroupName = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserPermissions)).BeginInit();
            this.groupBoxUserData.SuspendLayout();
            this.groupBoxUserGroup.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewUserPermissions
            // 
            this.dataGridViewUserPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserPermissions.Location = new System.Drawing.Point(6, 83);
            this.dataGridViewUserPermissions.Name = "dataGridViewUserPermissions";
            this.dataGridViewUserPermissions.RowTemplate.Height = 25;
            this.dataGridViewUserPermissions.Size = new System.Drawing.Size(502, 262);
            this.dataGridViewUserPermissions.TabIndex = 0;
            this.dataGridViewUserPermissions.Tag = "Users";
            this.dataGridViewUserPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserPermissions_CellContentClick);
            this.dataGridViewUserPermissions.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserPermissions_CellEndEdit);
            this.dataGridViewUserPermissions.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewUserPermissions_CellMouseUp);
            this.dataGridViewUserPermissions.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserPermissions_CellValueChanged);
            this.dataGridViewUserPermissions.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dataGridViewUserPermissions_CellValuePushed);
            // 
            // groupBoxUserData
            // 
            this.groupBoxUserData.Controls.Add(this.label7);
            this.groupBoxUserData.Controls.Add(this.label5);
            this.groupBoxUserData.Controls.Add(this.label4);
            this.groupBoxUserData.Controls.Add(this.comboBoxUserGroup);
            this.groupBoxUserData.Controls.Add(this.textBoxPassword);
            this.groupBoxUserData.Controls.Add(this.textBoxLogin);
            this.groupBoxUserData.Controls.Add(this.label3);
            this.groupBoxUserData.Controls.Add(this.label2);
            this.groupBoxUserData.Controls.Add(this.textBoxPosition);
            this.groupBoxUserData.Controls.Add(this.textBoxSurname);
            this.groupBoxUserData.Controls.Add(this.textBoxName);
            this.groupBoxUserData.Controls.Add(this.label1);
            this.groupBoxUserData.Location = new System.Drawing.Point(16, 69);
            this.groupBoxUserData.Name = "groupBoxUserData";
            this.groupBoxUserData.Size = new System.Drawing.Size(353, 384);
            this.groupBoxUserData.TabIndex = 1;
            this.groupBoxUserData.TabStop = false;
            this.groupBoxUserData.Text = "Dane użytkownika";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Grupa użytkowników";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Hasło";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Login";
            // 
            // comboBoxUserGroup
            // 
            this.comboBoxUserGroup.Enabled = false;
            this.comboBoxUserGroup.FormattingEnabled = true;
            this.comboBoxUserGroup.Location = new System.Drawing.Point(157, 287);
            this.comboBoxUserGroup.Name = "comboBoxUserGroup";
            this.comboBoxUserGroup.Size = new System.Drawing.Size(121, 23);
            this.comboBoxUserGroup.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(157, 243);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(121, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(157, 194);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.ReadOnly = true;
            this.textBoxLogin.Size = new System.Drawing.Size(121, 23);
            this.textBoxLogin.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stanowisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(157, 145);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.ReadOnly = true;
            this.textBoxPosition.Size = new System.Drawing.Size(121, 23);
            this.textBoxPosition.TabIndex = 3;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(157, 96);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.ReadOnly = true;
            this.textBoxSurname.Size = new System.Drawing.Size(121, 23);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(157, 48);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(121, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // groupBoxUserGroup
            // 
            this.groupBoxUserGroup.Controls.Add(this.buttonDeleteUserGroup);
            this.groupBoxUserGroup.Controls.Add(this.buttonSaveUserGroup);
            this.groupBoxUserGroup.Controls.Add(this.buttonEditUserGroup);
            this.groupBoxUserGroup.Controls.Add(this.buttonAddNewUserGroup);
            this.groupBoxUserGroup.Controls.Add(this.label6);
            this.groupBoxUserGroup.Controls.Add(this.textBoxUserGroupName);
            this.groupBoxUserGroup.Controls.Add(this.dataGridViewUserPermissions);
            this.groupBoxUserGroup.Location = new System.Drawing.Point(375, 69);
            this.groupBoxUserGroup.Name = "groupBoxUserGroup";
            this.groupBoxUserGroup.Size = new System.Drawing.Size(514, 384);
            this.groupBoxUserGroup.TabIndex = 2;
            this.groupBoxUserGroup.TabStop = false;
            this.groupBoxUserGroup.Text = "Grupa uzytkowników";
            // 
            // buttonDeleteUserGroup
            // 
            this.buttonDeleteUserGroup.Enabled = false;
            this.buttonDeleteUserGroup.Image = global::RejAndOlej.Properties.Resources.DeleteButton_16;
            this.buttonDeleteUserGroup.Location = new System.Drawing.Point(481, 354);
            this.buttonDeleteUserGroup.Name = "buttonDeleteUserGroup";
            this.buttonDeleteUserGroup.Size = new System.Drawing.Size(27, 25);
            this.buttonDeleteUserGroup.TabIndex = 6;
            this.buttonDeleteUserGroup.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUserGroup
            // 
            this.buttonSaveUserGroup.Enabled = false;
            this.buttonSaveUserGroup.Image = global::RejAndOlej.Properties.Resources.SaveButton_16;
            this.buttonSaveUserGroup.Location = new System.Drawing.Point(448, 354);
            this.buttonSaveUserGroup.Name = "buttonSaveUserGroup";
            this.buttonSaveUserGroup.Size = new System.Drawing.Size(27, 25);
            this.buttonSaveUserGroup.TabIndex = 5;
            this.buttonSaveUserGroup.UseVisualStyleBackColor = true;
            this.buttonSaveUserGroup.Click += new System.EventHandler(this.buttonSaveUserGroup_Click);
            // 
            // buttonEditUserGroup
            // 
            this.buttonEditUserGroup.Image = global::RejAndOlej.Properties.Resources.EditButton_16;
            this.buttonEditUserGroup.Location = new System.Drawing.Point(415, 354);
            this.buttonEditUserGroup.Name = "buttonEditUserGroup";
            this.buttonEditUserGroup.Size = new System.Drawing.Size(27, 25);
            this.buttonEditUserGroup.TabIndex = 4;
            this.buttonEditUserGroup.UseVisualStyleBackColor = true;
            this.buttonEditUserGroup.Click += new System.EventHandler(this.buttonEditUserGroup_Click);
            // 
            // buttonAddNewUserGroup
            // 
            this.buttonAddNewUserGroup.Image = global::RejAndOlej.Properties.Resources.AddButton_16;
            this.buttonAddNewUserGroup.Location = new System.Drawing.Point(382, 354);
            this.buttonAddNewUserGroup.Name = "buttonAddNewUserGroup";
            this.buttonAddNewUserGroup.Size = new System.Drawing.Size(27, 25);
            this.buttonAddNewUserGroup.TabIndex = 3;
            this.buttonAddNewUserGroup.UseVisualStyleBackColor = true;
            this.buttonAddNewUserGroup.Click += new System.EventHandler(this.buttonAddNewUserGroup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nazwa";
            // 
            // textBoxUserGroupName
            // 
            this.textBoxUserGroupName.Location = new System.Drawing.Point(198, 38);
            this.textBoxUserGroupName.Name = "textBoxUserGroupName";
            this.textBoxUserGroupName.ReadOnly = true;
            this.textBoxUserGroupName.Size = new System.Drawing.Size(133, 23);
            this.textBoxUserGroupName.TabIndex = 1;
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
            this.toolStrip1.Size = new System.Drawing.Size(909, 27);
            this.toolStrip1.TabIndex = 16;
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
            this.toolStripButtonSave.Enabled = false;
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
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::RejAndOlej.Properties.Resources.Print_256;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(24, 24);
            this.toolStripButtonPrint.Text = "Wydrukuj";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // uc_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBoxUserGroup);
            this.Controls.Add(this.groupBoxUserData);
            this.Name = "uc_Users";
            this.Size = new System.Drawing.Size(909, 487);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserPermissions)).EndInit();
            this.groupBoxUserData.ResumeLayout(false);
            this.groupBoxUserData.PerformLayout();
            this.groupBoxUserGroup.ResumeLayout(false);
            this.groupBoxUserGroup.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private const string strUser = "User";
        private const string strUserGroup = "UserGroup";
        private string activeModel;
        private User currentUser;
        private RejAndOlejContext context;
        private System.Windows.Forms.DataGridView dataGridViewUserPermissions;
        private System.Windows.Forms.GroupBox groupBoxUserData;
        private System.Windows.Forms.GroupBox groupBoxUserGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUserGroup;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonAddNewUserGroup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserGroupName;
        private System.Windows.Forms.Button buttonSaveUserGroup;
        private System.Windows.Forms.Button buttonEditUserGroup;
        private System.Windows.Forms.Button buttonDeleteUserGroup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSearch;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
    }
}
