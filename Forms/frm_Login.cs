using RejAndOlej.DATABASE;
using RejAndOlej.DATABASE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejAndOlej.Forms
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();

            context = new RejAndOlejContext();

        }

        public User LoginUser { get => loginUser; }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            label1.Text = "Zaloguj się do programu Rej&&Olej";
        }

        private void sbLogin_Click(object sender, EventArgs e)
        {
            User user = context.Users.Where(u => u.Login == textBoxLogin.Text && u.Password == textBoxPassword.Text).FirstOrDefault();

            if (user != null)
            {
                loginUser = user;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika lu hasło", "Błąd logowania");
            }
        }

        private void sbCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
                sbLogin.Enabled = true;
            else
                sbLogin.Enabled = false;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != "" && textBoxPassword.Text != "")
                sbLogin.Enabled = true;
            else
                sbLogin.Enabled = false;
        }
    }
}
