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
    public partial class mainMenuForm : Form
    {
        public int Option = 0;
        public mainMenuForm()
        {
            InitializeComponent();
        }


        private void carAddButton_Click(object sender, EventArgs e)
        {
            int Option;
            this.Hide();
            Option = 1;
            carForm carForm = new carForm(Option);
            carForm.Show();
        }
        // ==================================================================================== Zarządzanie samochodami
        private void carEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            carForm carOpenForm = new carForm(Option);
            carOpenForm.Show();
        }

        private void carRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            carForm carOpenForm = new carForm(Option);
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
