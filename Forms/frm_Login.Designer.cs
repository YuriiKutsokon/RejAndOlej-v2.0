
using RejAndOlej.DATABASE;
using System.Windows.Forms;

namespace RejAndOlej.Forms
{
    partial class frm_Login
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
            this.sbLogin = new System.Windows.Forms.Button();
            this.sbCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sbLogin
            // 
            this.sbLogin.Enabled = false;
            this.sbLogin.Image = global::RejAndOlej.Properties.Resources.OKButton_16;
            this.sbLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbLogin.Location = new System.Drawing.Point(522, 176);
            this.sbLogin.Name = "sbLogin";
            this.sbLogin.Size = new System.Drawing.Size(104, 25);
            this.sbLogin.TabIndex = 0;
            this.sbLogin.Text = "Zaloguj";
            this.sbLogin.UseVisualStyleBackColor = true;
            this.sbLogin.Click += new System.EventHandler(this.sbLogin_Click);
            // 
            // sbCancel
            // 
            this.sbCancel.Image = global::RejAndOlej.Properties.Resources.CancelButton_16;
            this.sbCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbCancel.Location = new System.Drawing.Point(412, 176);
            this.sbCancel.Name = "sbCancel";
            this.sbCancel.Size = new System.Drawing.Size(104, 25);
            this.sbCancel.TabIndex = 1;
            this.sbCancel.Text = "Anuluj";
            this.sbCancel.UseVisualStyleBackColor = true;
            this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Zaloguj się do programu Rej&Oej";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(207, 75);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(235, 23);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(207, 115);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(235, 23);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nazwa Użytkownika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hasło";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 213);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sbCancel);
            this.Controls.Add(this.sbLogin);
            this.Name = "frm_Login";
            this.Text = "Zaloguj";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RejAndOlejContext context;
        private System.Windows.Forms.Button sbLogin;
        private System.Windows.Forms.Button sbCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}