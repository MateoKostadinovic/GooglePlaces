using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using CRUD;
using REST;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Data.Common;
using System.Data.SqlClient;

namespace GooglePlaces
{
    public partial class Form1 : Form
    {
        public List<GooglePlacesView> lGPlaces = new List<GooglePlacesView>();
        public Form1()
        {
            InitializeComponent();
            Crud oCrud = new Crud();
            List<Types> lTypes = new List<Types>();
            List<City> lCities = new List<City>();
            lCities = oCrud.GetAllCities();
            lTypes = oCrud.GetAllTypes();
            
            dataGridViewTypes.DataSource = lTypes;
            dataGridViewCities.DataSource = lCities;


            //button za uredivanje tipova
            DataGridViewImageColumn oEditButtonType = new DataGridViewImageColumn();//nova kolona tipa Image
            oEditButtonType.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\KV\\if_ic_mode_edit_48px_352547.png");
            oEditButtonType.Width = 20;
            oEditButtonType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTypes.Columns.Add(oEditButtonType);

            //buttona za uredivanje gradova
            DataGridViewImageColumn oEditButtonCity = new DataGridViewImageColumn();//nova kolona tipa Image
            oEditButtonCity.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\KV\\if_ic_mode_edit_48px_352547.png");
            oEditButtonCity.Width = 20;
            oEditButtonCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCities.Columns.Add(oEditButtonCity);

            //button za brisanje tipa
            DataGridViewImageColumn oDeleteButtonType = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButtonType.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\KV\\if_ic_delete_48px_352303.png");
            oDeleteButtonType.Width = 20;
            oDeleteButtonType.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTypes.Columns.Add(oDeleteButtonType);

            //button za brisanje grada
            DataGridViewImageColumn oDeleteButtonCity = new DataGridViewImageColumn();//nova kolona tipa Image
            oDeleteButtonCity.Image = Image.FromFile("C:\\Fakultet\\Programiranje u .NET okolini\\KV\\if_ic_delete_48px_352303.png");
            oDeleteButtonCity.Width = 20;
            oDeleteButtonCity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCities.Columns.Add(oDeleteButtonCity);

            dataGridViewTypes.AutoGenerateColumns = false;//program nece sam stvoriti sve kolone, lijepo ce se posloziti
            dataGridViewCities.AutoGenerateColumns = false;


            //COMBO-BOX GRADOVI
            List<String> lCity = lCities.Where(o => o.sCityName != "").Select(o => o.sCityName).Distinct().ToList();
            comboBoxCity.DataSource = lCity;

            //COMBO-BOX TIPOVI
            List<String> lType = lTypes.Where(o => o.sTypeValue != "").Select(o => o.sTypeValue).Distinct().ToList();
            comboBoxType.DataSource = lType;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            FormAddType FormAddType = new FormAddType(this);
            FormAddType.Show();
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            FormAddCity FormAddCity = new FormAddCity(this);
            FormAddCity.Show();
        }

        private void dataGridViewTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewTypes.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewTypes.CurrentCell.ColumnIndex.Equals(3) && e.RowIndex != -1)
            {
                FormEditType FormEditType = new FormEditType(this);//kreira novu formu koja prima objekt tipa Form1 sa pokazivacem this
                FormEditType.lblTypeId.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditType.inptEditTypeName.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditType.inptEditTypeValue.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditType.Show();
            }
            if (dataGridViewTypes.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                FormDeleteType FormDeleteType = new FormDeleteType(this);
                FormDeleteType.lblDeleteTypeId.Text = dataGridViewTypes.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteType.Show();
            }
        }

        private void dataGridViewCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCities.Rows[e.RowIndex].Selected = true;//zapamti na kojem smo retku kliknuli gumbic = selektiran
            if (dataGridViewCities.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                FormEditCity FormEditCity = new FormEditCity(this);//kreira novu formu koja prima objekt tipa Form1 sa pokazivacem this
                FormEditCity.lblCityId.Text = dataGridViewCities.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormEditCity.inptEditCityName.Text = dataGridViewCities.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditCity.inptEditCityLat.Text = dataGridViewCities.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditCity.inptEditCityLng.Text = dataGridViewCities.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditCity.Show();
            }
            if (dataGridViewCities.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                FormDeleteCity FormDeleteCity = new FormDeleteCity(this);
                FormDeleteCity.lblDeleteCityId.Text = dataGridViewCities.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteCity.Show();
            }
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Mateo Kostadinović");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Rest oRest = new Rest();
            string sCity = (string)comboBoxCity.SelectedItem;
            string sType = (string)comboBoxType.SelectedItem;
            float fRadius = (float)trackBarRadius.Value;
            lGPlaces = oRest.GetPlaces(sCity, sType, fRadius);
            dataGridViewLocations.DataSource = lGPlaces;
        }

    }
}
