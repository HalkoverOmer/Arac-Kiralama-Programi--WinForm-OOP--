using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kiralama_Programi__WinForm_OOP__
{
    public partial class frmModels : Form
    {
        public frmModels()
        {
            InitializeComponent();
        }

        List<string> models = new List<string>();
        public static string path = Application.StartupPath + "models.json"; 

        private void AddDataListBox()
        {
            lstModelNames.DataSource = null;
            lstModelNames.DataSource = models;
        }

        private static JsonSerializerOptions CreateJsonSerializerOptions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.WriteIndented = true;
            return options;
        }

        private void SaveData()
        {
            string json = JsonSerializer.Serialize(models, CreateJsonSerializerOptions());
            File.WriteAllText(path, json);
        }

        public static List<string> ReadData()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                List<string> list = JsonSerializer.Deserialize<List<string>>(json, CreateJsonSerializerOptions());
                return list;
            }

            else
            {
                return new List<string>();
            }

        }

        private void frmModels_Load(object sender, EventArgs e)
        {
            List<string> list = ReadData();
            models = list;
            AddDataListBox();
        }

        private void btnDeleteModel_Click(object sender, EventArgs e)
        {
            models.RemoveAt(lstModelNames.SelectedIndex);
            AddDataListBox();
            SaveData();
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            models.Add(txtModelName.Text);
            AddDataListBox();
            SaveData();

        }

        private void txtModelName_TextChanged(object sender, EventArgs e)
        {
            if (txtModelName.Text.Length > 0)
            {
                btnAddModel.Enabled = true;
            }

            else
            {
                btnAddModel.Enabled = false;
            }
        }

        private void lstModelNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstModelNames.SelectedIndex != -1)
            {
                btnSaveModel.Enabled = true;
                btnDeleteModel.Enabled = true;
            }

            else
            {
                btnSaveModel.Enabled = false;
                btnDeleteModel.Enabled = false;
            }
        }

        private void btnSaveModel_Click(object sender, EventArgs e)
        {
            models[lstModelNames.SelectedIndex] = txtModelName.Text;
            AddDataListBox();
            SaveData();
        }
    }
}
