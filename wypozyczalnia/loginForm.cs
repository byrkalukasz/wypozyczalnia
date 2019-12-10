﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wypozyczalnia.Bizness;
using System.Threading;

namespace wypozyczalnia
{
    public partial class loginForm : Form
    {
        Thread newThread;
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
        private void openNewForm_mainMenuForm()
        {
            Form formSelected = new mainMenuForm();
            Application.Run(formSelected);
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