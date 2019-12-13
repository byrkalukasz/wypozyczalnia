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
        public carForm(int _option)
        {
            InitializeComponent();
            Car car = new Car();
            if (_option == 1)
                carIdentifier_groupBox.Visible = false;
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
            mainMenuForm mainMenuOpenForm = new mainMenuForm();
            mainMenuOpenForm.Show();
        }

        private void carForm_Load(object sender, EventArgs e)
        {

        }
    }
}
