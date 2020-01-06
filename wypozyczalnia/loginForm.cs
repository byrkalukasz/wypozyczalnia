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
            Login login = new Login();
            string Login = login_textBox.Text, Password = password_textBox.Text;
            bool Check = login.ValidateCredentials(Login, Password);
            if (Check == true)
            {

                this.Hide();
                mainMenuForm menu = new mainMenuForm(Login);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Podano błedne dane logowanie lub konto zablokowane");
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