using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wypozyczalnia
{
    public partial class personForm : Form
    {
        public string Login;
        public personForm(string _who)
        {

            InitializeComponent();
        }
        public void isSelectedChecker()
        {
            if (((this.personIdentifierTypeCustomer_radioButton.Checked) || (this.personIdentifierTypeEmployee_radioButton.Checked)) && ((this.personIdentifierClientTypeCompany_radioButton.Checked) || (this.personIdentifierClientTypeHuman_radioButton.Checked)))
            {
                this.personInfo_groupBox.Enabled = true;
                this.personRemove_button.Enabled = true;
                this.personSave_button.Enabled = true;
            }
        }

        public void personIdentifierValueWorker(int value, object sender)
        {
            string valueString = this.personIdentifierID_textBox.Text;
            int valueNumeric = Int32.Parse(valueString) + value;
            this.personIdentifierID_textBox.Text = valueNumeric.ToString();
        }
        private void personIdentifierTypeCustomer_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
            this.personInfoPassword_textBox.Enabled = false;
            this.personInfoLogin_textBox.Enabled = false;
            this.personInfoSalary_textBox.Enabled = false;
            this.personInfoJobPosition_comboBox.Enabled = false;
        }

        private void personIdentifierTypeEmployee_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
            this.personInfoPassword_textBox.Enabled = true;
            this.personInfoLogin_textBox.Enabled = true;
            this.personInfoSalary_textBox.Enabled = true;
            this.personInfoJobPosition_comboBox.Enabled = true;
        }

        private void personIdentifierClientTypeHuman_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
            this.personInfoCompanyName_textBox.Enabled = false;
            this.personInfoFaks_textBox.Enabled = false;
            this.personInfoNip_maskedTextBox.Enabled = false;
            this.personInfoName_textBox.Enabled = true;
            this.personInfoSurname_textBox.Enabled = true;
            this.personInfoPesel_maskedTextBox.Enabled = true;
        }

        private void personIdentifierClientTypeCompany_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            isSelectedChecker();
            this.personInfoCompanyName_textBox.Enabled = true;
            this.personInfoFaks_textBox.Enabled = true;
            this.personInfoNip_maskedTextBox.Enabled = true;
            this.personInfoName_textBox.Enabled = false;
            this.personInfoSurname_textBox.Enabled = false;
            this.personInfoPesel_maskedTextBox.Enabled = false;
        }

        private void personIdentifierNextID_button_Click(object sender, EventArgs e)
        {
            personIdentifierValueWorker(1, this.personIdentifierID_textBox.Text);
        }

        private void personIdentifierPrevID_button_Click(object sender, EventArgs e)
        {
            personIdentifierValueWorker(-1, this.personIdentifierID_textBox.Text);
        }

        private void personRemove_button_Click(object sender, EventArgs e)
        {

        }

        private void personSave_button_Click(object sender, EventArgs e)
        {

        }
        private void carCancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenuForm mainMenuOpenForm = new mainMenuForm(Login);
            mainMenuOpenForm.Show();
        }

        private void personForm_Load(object sender, EventArgs e)
        {

        }
    }
}
