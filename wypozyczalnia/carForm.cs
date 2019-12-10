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
    public partial class carForm : Form
    {
        Thread newThread;
        public carForm()
        {
            InitializeComponent();
        }
        private void openNewForm_mainMenuForm()
        {
            Form formSelected = new mainMenuForm();
            Application.Run(formSelected);
        }

        private void carSave_button_Click(object sender, EventArgs e)
        {

        }

        private void carRemove_button_Click(object sender, EventArgs e)
        {

        }
        private void carCancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            newThread = new Thread(openNewForm_mainMenuForm);
            newThread.SetApartmentState(ApartmentState.STA);
            newThread.Start();
        }
    }
}
