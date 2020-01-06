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
    public partial class carForm : Form
    {
        public string Login;
        public carForm(int _option, string _login)
        {
            InitializeComponent();
            this.Login = _login;
            Car car = new Car();
            if (_option == 1)
                carIdentifier_groupBox.Visible = false;
        }
        public void carIdentifierValueWorker(int value, object sender)
        {
            string valueString = this.carIdentifierID_textBox.Text;
            int valueNumeric = Int32.Parse(valueString) + value;
            this.carIdentifierID_textBox.Text = valueNumeric.ToString();
        }

        private void carSave_button_Click(object sender, EventArgs e)
        {

        }

        private void carRemove_button_Click(object sender, EventArgs e)
        {

        }

        private void carCancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForm mainMenuOpenForm = new mainMenuForm(Login);
            mainMenuOpenForm.Show();
        }

        private void carIdentifierNextID_button_Click(object sender, EventArgs e)
        {
            carIdentifierValueWorker(+1, this.carIdentifierID_textBox.Text);
        }

        private void carIdentifierPrevID_button_Click(object sender, EventArgs e)
        {
            carIdentifierValueWorker(-1, this.carIdentifierID_textBox.Text);
        }
        private void carForm_Load(object sender, EventArgs e)
        {

        }
    }
}
