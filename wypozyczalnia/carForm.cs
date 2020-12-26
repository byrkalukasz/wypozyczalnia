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
        public int ID_CAR;
        public string Option;
        public carForm(string _option, string _login)
        {
            InitializeComponent();
            this.Login = _login;
            this.Option = _option;
            Car car = new Car();
            if (_option == "Add")
            {
                carIdentifier_groupBox.Visible = false;
                carSave_button.Text = "DODAJ";
            }
            if (_option == "Edit")
            {
                carRemove_button.Visible = false;
                carSave_button.Text = "EDYTUJ";
            }
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
            List<Car> CarUpdateData = new List<Car>();
            if (Option == "Add")
            {
                Car AddCar = new Car();
                AddCar.AddCar(carInfoProducent_textBox.Text, carInfoModel_textBox.Text);
                int ID = AddCar.GetCarID(carInfoProducent_textBox.Text, carInfoModel_textBox.Text);
                AddCar.AddCarData(carInfoYear_textBox.Text, carInfoBody_comboBox.Text, carInfoDoors_textBox.Text, carInfoPassengers_textBox.Text, carInfoBodyColor_textBox.Text, carInfoDataTechnicalReview_dateTimePicker.Text, carInfoDataOC_dateTimePicker.Text, carInfoMileage_textBox.Text, carInfoLicensePlate_textBox.Text, carInfoVIN_textBox.Text, ID);
                AddCar.AddCarPrize(carPriceDay_textBox.Text, carPriceWeek_textBox.Text, carPriceMonth_textBox.Text, carInfoYear_textBox.Text, ID);
                this.Hide();
                mainMenuForm mainMenuForm = new mainMenuForm(Login);
            }
            if (Option == "Edit")
            {
                Car EditCar = new Car();
                if (carIdentifierID_textBox.Text == null)
                {
                    MessageBox.Show("Nie wybrano samochodu do edycji");
                }
                else
                {
                    CarUpdateData.Add(new Car()
                    {
                        DayPrize = Convert.ToInt32(carPriceDay_textBox.Text.ToString()),
                        WeekPrize = Convert.ToInt32(carPriceWeek_textBox.Text.ToString()),
                        MonthPrize = Convert.ToInt32(carPriceMonth_textBox.Text.ToString()),
                        YearPrize = Convert.ToInt32(carPriceYear_textBox.Text.ToString()),
                        Car_ID = ID_CAR,
                        CarData_ID = Convert.ToInt32(carIdentifierID_textBox.Text.ToString())
                    });
                    EditCar.EditCar(CarUpdateData);
                }
            }

        }

        private void carRemove_button_Click(object sender, EventArgs e)
        {
            if (carIdentifierID_textBox.Text == null)
            {
                MessageBox.Show("Nie wybrano samochodu do usnięcia");
            }
            else
            {
                Car Delete = new Car();
                Delete.DeleteCar(Convert.ToInt32(carIdentifierID_textBox.Text));
            }
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
            int Checker = 0;
                    do
                    {
                        carIdentifierValueWorker(+1, this.carIdentifierID_textBox.Text);
                        CarData = GetCarData.GetCarData(Convert.ToInt32(carIdentifierID_textBox.Text));
                        Checker++;
                if (Checker == 100)
                {
                    MessageBox.Show("Następne 100 pozycji było pustych, nie odnaleziono samochodu, Jeżeli to błąd zgłosć ten fakt do administratora.");
                    int value = Convert.ToInt32(carIdentifierID_textBox.Text) - 100;
                    carIdentifierID_textBox.Text = value.ToString();
                    goto End;
                } 
                    } while (CarData.Count == 0);
            carInfoProducent_textBox.Text = CarData[0].Marka;
            carInfoModel_textBox.Text = CarData[0].Model;
            carInfoYear_textBox.Text = CarData[0].Rocznik.ToString();
            carInfoDoors_textBox.Text = CarData[0].LiczbaDrzwi.ToString();
            carInfoBody_comboBox.Text = CarData[0].Nadwozie.ToString();
            carInfoPassengers_textBox.Text = CarData[0].MaxPasazerow.ToString();
            carInfoBodyColor_textBox.Text = CarData[0].KolorNadwozia.ToString();
            carInfoDataTechnicalReview_dateTimePicker.Text = CarData[0].DataPrzegladu.ToString();
            carInfoDataOC_dateTimePicker.Text = CarData[0].DataUbezpieczenia.ToString();
            carInfoMileage_textBox.Text = CarData[0].Przebieg.ToString();
            carInfoLicensePlate_textBox.Text = CarData[0].NumerRejestracyjny.ToString();
            carInfoVIN_textBox.Text = CarData[0].NumerVIN;
            carPriceDay_textBox.Text = CarData[0].DayPrize.ToString();
            carPriceWeek_textBox.Text = CarData[0].WeekPrize.ToString();
            carPriceMonth_textBox.Text = CarData[0].MonthPrize.ToString();
            carPriceYear_textBox.Text = CarData[0].YearPrize.ToString();
            ID_CAR = CarData[0].Car_ID;
        End:;
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
