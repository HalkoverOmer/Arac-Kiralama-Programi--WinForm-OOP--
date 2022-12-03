using System.Text.Json;

namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>();
        List<Rent> rents = new List<Rent>();

        private string pathCars = Application.StartupPath + "cars.json";
        private string pathRents = Application.StartupPath + "rents.json";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void markaYönetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBrands frm = new frmBrands();
            frm.ShowDialog();

        }

        private void tsmModels_Click(object sender, EventArgs e)
        {
            frmModels frm = new frmModels();
            frm.ShowDialog();
        }

        private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBrand.DataSource = null;
            cmbBrand.DataSource = frmBrands.ReadData();

            cmbModels.DataSource = null;
            cmbModels.DataSource = frmModels.ReadData();

            if (File.Exists(pathCars))
            {
                string json = File.ReadAllText(pathCars);
                cars = JsonSerializer.Deserialize<List<Car>>(json);
                lstCars.DataSource = null;
                lstCars.DataSource = cars;
            }

            

            if (File.Exists(pathRents))
            {
                string json = File.ReadAllText (pathRents);
                rents = JsonSerializer.Deserialize<List<Rent>>(json);
                lstCustomerRents.DataSource = null;
                lstCustomerRents.DataSource = rents;
            }
        }

        private void btnCarInfoAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Brand = cmbBrand.Text,
                Model = cmbModels.Text,
                KM = (int)nudKM.Value,
                Year = (int)nudYear.Value,
                DailyPrice = (decimal)nudDailyPrice.Value,
                IsRent = chkRent.Checked,
                ImagePath = pbPicture.ImageLocation
            };

            cars.Add(car);
            lstCars.DataSource = null;
            lstCars.DataSource = cars;
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Resim Seç";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            openFileDialog.Filter = "Resim Dosyalarý| *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbPicture.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnCarsDelete_Click(object sender, EventArgs e)
        {
            if (lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Araç seçmeden iþlem yapamazsýnýz...");
                return;
            }

            cars.RemoveAt(lstCars.SelectedIndex);
            lstCars.DataSource = null;
            lstCars.DataSource = cars;
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yenidenBaþlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

            if (lstCars.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir araç seçiniz..");
                return;
            }

            Rent rent = new Rent
            {
                FullName = txtCustomerName.Text,
                SNNo = decimal.Parse(txtCustomerSN.Text),
                StartDate = dtpStartDate.Value.Date,
                EndDate = dtpEndDate.Value.Date,
                DownPayment = nudFirstPayment.Value
            };

            Car selectedCar = lstCars.SelectedItem as Car;
            rent.car = selectedCar;
            rents.Add(rent);
            lstCustomerRents.DataSource = null;
            lstCustomerRents.DataSource = rents;
        }

        private void btnDeleteRent_Click(object sender, EventArgs e)
        {
            if (lstCustomerRents.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kayýt seçiniz..");
                return;
            }

            if (lstCustomerRents.SelectedIndex != -1)
            {
                rents.RemoveAt(lstCars.SelectedIndex);
                lstCustomerRents.DataSource = null;
                lstCustomerRents.DataSource = rents;
            }

            else
            {
                MessageBox.Show("Silmek için kayýt seçmelisiniz...");
                return;
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string jsonCars = JsonSerializer.Serialize(cars, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathCars, jsonCars);

            string jsonRents = JsonSerializer.Serialize(rents, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathRents, jsonRents);
        }
    }
}