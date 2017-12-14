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
    public partial class FormEditCity : Form
    {
        private readonly Form1 FormEditCities;
        public FormEditCity(Form1 FormEditC)
        {
            FormEditCities = FormEditC;
            InitializeComponent();
        }

        private void btnEditCity_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(inptEditCityName.Text);
            City oCity = new City();
            oCity.nCityID = Int32.Parse(lblCityId.Text);
            oCity.sCityName = inptEditCityName.Text;
            oCity.fCityLat = Convert.ToSingle(inptEditCityLat.Text);
            oCity.fCityLng = Convert.ToSingle(inptEditCityLng.Text);
            Crud oCrud = new Crud();
            oCrud.UpdateCity(oCity);

            this.FormEditCities.dataGridViewCities.DataSource = oCrud.GetAllCities();
            this.Hide();
        }
    }
}
