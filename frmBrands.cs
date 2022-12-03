using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    public partial class frmBrands : Form
    {
        public frmBrands()
        {
            InitializeComponent();
        }

        private List<string> Brands= new List<string>();
        public static string path = Application.StartupPath + "brands.json";

        private void AddDataListBox()
        {
            lstBrandNames.DataSource = null;
            lstBrandNames.DataSource = Brands;
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(Brands, CreateJsonSerializerOptions());
            File.WriteAllText(path, json);
        }

        private static JsonSerializerOptions CreateJsonSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            return options;
        }

        public static List<string> ReadData()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<string> list = JsonSerializer.Deserialize<List<string>>(json,CreateJsonSerializerOptions());
                return list;
            }

            else
            {
                return new List<string>();
            }
        }


        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            Brands.Add(txtBrandName.Text);
            AddDataListBox();
            SaveData();
        }

        private void btnSaveBrand_Click(object sender, EventArgs e)
        {
            Brands[lstBrandNames.SelectedIndex] = txtBrandName.Text;
            AddDataListBox();
            SaveData();
        }

        private void btnDeleteBrand_Click(object sender, EventArgs e)
        {
            Brands.RemoveAt(lstBrandNames.SelectedIndex);
            AddDataListBox();
            SaveData();
        }

        private void txtBrandName_TextChanged(object sender, EventArgs e)
        {
            if (txtBrandName.Text.Length > 0)
            {
                btnAddBrand.Enabled = true;
            }

            else
            {
                btnAddBrand.Enabled = false;
            }
        }

        private void lstBrandNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBrandNames.SelectedIndex != -1)
            {
                btnSaveBrand.Enabled = true;
                btnDeleteBrand.Enabled = true;
            }

            else
            {
                btnSaveBrand.Enabled = false;
                btnDeleteBrand.Enabled = false;
            }
        }

        private void frmBrands_Load(object sender, EventArgs e)
        {
            List<string> list = ReadData();
            Brands = list;
            AddDataListBox();
        }
    }
}
