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
    public partial class mainMenuForm : Form
    {
        public mainMenuForm()
        {
            InitializeComponent();
        }


        private void carAddButton_Click(object sender, EventArgs e)
        {

        }
        // ==================================================================================== Zarządzanie samochodami
        private void carEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            carForm carOpenForm = new carForm();
            carOpenForm.Show();
        }

        private void carRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            carForm carOpenForm = new carForm();
            carOpenForm.Show();
        }
        // ==================================================================================== Zarządzanie klientami
        private void customerCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }

        private void customerEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }

        private void customerRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }
        // ==================================================================================== Zarządzanie rezerwacjami
        private void reservationsAddButton_Click(object sender, EventArgs e)
        {
            
        }

        private void reservationsEditButton_Click(object sender, EventArgs e)
        {
            
        }

        private void reservationsRemoveButton_Click(object sender, EventArgs e)
        {
            
        }
        // ==================================================================================== Zarządzanie pracownikami
        private void employeeCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }

        private void employeeEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }

        private void employeeRemoveButton_Click(object sender, EventArgs e)
        {
             this.Hide();
            personForm personOpenForm = new personForm();
            personOpenForm.Show();
        }
        // ====================================================================================
        private void buttonCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
