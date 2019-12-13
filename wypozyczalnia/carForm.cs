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
    public partial class carForm : Form
    {
        public carForm()
        {
            InitializeComponent();
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
    }
}
