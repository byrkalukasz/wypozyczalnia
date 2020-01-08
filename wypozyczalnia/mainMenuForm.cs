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
        public string Option = null;
        public string Login;
        public mainMenuForm(string _login)
        {
            InitializeComponent();
            this.Login = _login;
            this.whoLoginInLabel.Text = "Zalogowany: " + Login;
        }


        private void carAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option = "Add";
            carForm carForm = new carForm(Option, Login);
            carForm.Show();
        }
        // ==================================================================================== Zarządzanie samochodami
        private void carEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option = "Edit";
            carForm carOpenForm = new carForm(Option, Login);
            carOpenForm.Show();
        }

        private void carRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Option = "Delete";
            carForm carOpenForm = new carForm(Option, Login);
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
        // ==================================================================================== Zarządzanie rezerwacjami i wynajmem
        private void reservationsAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
        }

        private void reservationsEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
        }

        private void reservationsRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
        }

        private void rentAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
        }

        private void rentEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
        }

        private void rentRemoveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rentReserveCar rentReserveCarOpenForm = new rentReserveCar(Option, Login);
            rentReserveCarOpenForm.Show();
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
