using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace wypozyczalnia
{
    public partial class mainMenuForm : Form
    {
        Thread newThread;
        public mainMenuForm()
        {
            InitializeComponent();
        }
        private void openNewForm_mainMenuForm()
        {
            Form formSelected = new mainMenuForm();
            Application.Run(formSelected);
        }
        private void openNewForm_loginForm()
        {
            Form formSelected = new loginForm();
            Application.Run(formSelected);
        }
        private void openNewForm_carForm()
        {
            Form formSelected = new carForm();
            Application.Run(formSelected);
        }
        private void openNewForm_personForm()
        {
            Form formSelected = new personForm();
            Application.Run(formSelected);
        }
        private void openNewForm_reservationForm()
        {
            // Łukasz. Tutaj trzeba pózniej zmienić. Trzeba dać rzeczywisty formularz
            Form formSelected = new mainMenuForm();
            Application.Run(formSelected);
        }
        // ==================================================================================== Zarządzanie samochodami
        private void carAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_carForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void carEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_carForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void carRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_carForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
        // ==================================================================================== Zarządzanie klientami
        private void customerCreateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void customerEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void customerRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
        // ==================================================================================== Zarządzanie rezerwacjami
        private void reservationsAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_reservationForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void reservationsEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_reservationForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void reservationsRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_reservationForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
        // ==================================================================================== Zarządzanie pracownikami
        private void employeeCreateButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void employeeEditButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }

        private void employeeRemoveButton_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_personForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
        // ====================================================================================
        private void buttonCloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
