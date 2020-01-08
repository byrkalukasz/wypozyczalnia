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
        public carForm(string _option, string _login)
        {
            InitializeComponent();
            this.Login = _login;
            Car car = new Car();
            if (_option == "Add")
                carIdentifier_groupBox.Visible = false;
            if (_option == "Edit")
                carRemove_button.Visible = false;
            if (_option == "Delete")
                carSave_button.Visible = false;
        }
        public void carIdentifierValueWorker(int value, object sender)
        {
            string valueString = this.carIdentifierID_textBox.Text;
            int valueNumeric = Int32.Parse(valueString) + value;
            this.carIdentifierID_textBox.Text = valueNumeric.ToString();
        }

        private void carSave_button_Click(object sender, EventArgs e)
        {
            
            Car AddCar = new Car();
            AddCar.AddCar(carInfoProducent_textBox.Text, carInfoModel_textBox.Text);
            int ID = AddCar.GetCarID(carInfoProducent_textBox.Text, carInfoModel_textBox.Text);
            AddCar.AddCarData(carInfoYear_textBox.Text,carInfoBody_comboBox.Text,carInfoDoors_textBox.Text,carInfoPassengers_textBox.Text,carInfoBodyColor_textBox.Text,carInfoDataTechnicalReview_dateTimePicker.Text,carInfoDataOC_dateTimePicker.Text,carInfoMileage_textBox.Text, carInfoLicensePlate_textBox.Text,carInfoVIN_textBox.Text, ID);
            AddCar.AddCarPrize(carPriceDay_textBox.Text, carPriceWeek_textBox.Text, carPriceMonth_textBox.Text, carInfoYear_textBox.Text,ID);
            this.Hide();
            mainMenuForm mainMenuForm = new mainMenuForm(Login);

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
            List<Car> CarData = new List<Car>();
            Car GetCarData = new Car();
            do
            {
                carIdentifierValueWorker(+1, this.carIdentifierID_textBox.Text);
                CarData = GetCarData.GetCarData(Convert.ToInt32(carIdentifierID_textBox.Text));
            } while(CarData.Count == 0);
            carInfoYear_textBox.Text = CarData[0].Rocznik.ToString();
            carInfoDoors_textBox.Text = CarData[0].LiczbaDrzwi.ToString();
            carInfoBody_comboBox.Text = CarData[0].Nadwozie.ToString();
            carInfoPassengers_textBox.Text = CarData[0].MaxPasazerow.ToString();
            carInfoBodyColor_textBox.Text = CarData[0].KolorNadwozia.ToString();

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
