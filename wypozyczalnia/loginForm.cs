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

        private void login_button_Click(object sender, EventArgs e)
        {
            int Check;
            Login login = new Login();
            Check = login.DataCheck(login_textBox.Text, password_textBox.Text);
            if (Check == 1)
            {
                this.Hide();
                mainMenuForm mainMenu = new mainMenuForm();
                mainMenu.Show();
            }
            else
            {
                //Michał : Sprawdz czy tekst w alercie jest poprawny, narazie dałem na sztywno błędne logowanie, po zrobieniu bazy dam ci skrypt do niej i będziesz mógł się bawić samemu.
                MessageBox.Show("Błąd logowania Proszę o kontakt z kierownikiem", "Błąd logowania");
            }
        }
    }
}