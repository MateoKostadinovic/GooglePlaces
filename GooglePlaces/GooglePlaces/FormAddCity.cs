using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CRUD;

namespace GooglePlaces
{
    public partial class FormAddCity : Form
    {
        private readonly Form1 FormAddCities;
        public FormAddCity(Form1 FormAddC)
        {
            FormAddCities = FormAddC;
            InitializeComponent();
        }

        private void btnAddCity2_Click(object sender, EventArgs e)
        {
            City oCity = new City();
            oCity.sCityName = inptAddCityName.Text;
            oCity.dCityLat = Convert.ToDecimal(inptAddCityLat.Text);
            oCity.dCityLng = Convert.ToDecimal(inptAddCityLng.Text);
            latview.Text = "" + inptAddCityLat;

            Crud oCrud = new Crud();
            oCrud.SaveNewCity(oCity);

            this.FormAddCities.dataGridViewCities.DataSource = oCrud.GetAllCities();
            this.Hide();
        }
    }
}
