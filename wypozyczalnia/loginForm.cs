using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Bizness;

namespace wypozyczalnia
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        public void isSelectedChecker()
        {
            if ((this.login_textBox.Text != "") && (this.password_textBox.Text != ""))
            {
                this.login_button.Enabled = true;
            }
            else
            {
                this.login_button.Enabled = false;
            }
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            int Check;
            Login login = new Login();
            login.DataCheck(login_textBox.Text, password_textBox.Text);
            Check = login.Status;
            if (Check == 1)
            {
                this.Hide();
                mainMenuForm mainMenuOpenForm = new mainMenuForm();
                mainMenuOpenForm.Show();
            }
            else
            {
                MessageBox.Show("Błąd logowania Proszę o kontakt z kierownikiem", "Błąd logowania");
            }
        }

        private void login_textBox_TextChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
        }
    }
}