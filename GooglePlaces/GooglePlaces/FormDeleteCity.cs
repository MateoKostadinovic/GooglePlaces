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
    public partial class FormDeleteCity : Form
    {
        private readonly Form1 FormDeleteCities;
        public FormDeleteCity(Form1 FormDeleteC)
        {
            FormDeleteCities = FormDeleteC;
            InitializeComponent();
        }

        private void btnDeleteCityClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCityDelete_Click(object sender, EventArgs e)
        {
            int nCityId = Int32.Parse(lblDeleteCityId.Text);
            Crud oCrud = new Crud();
            oCrud.DeleteCity(nCityId);
        }
    }
}
