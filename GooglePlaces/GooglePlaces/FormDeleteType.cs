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
    public partial class FormDeleteType : Form
    {
        private readonly Form1 FormDeleteTypes;
        public FormDeleteType(Form1 FormDeleteT)
        {
            FormDeleteTypes = FormDeleteT;
            InitializeComponent();
        }

        private void btnTypeDelete_Click(object sender, EventArgs e)
        {
            int nTypeId = Int32.Parse(lblDeleteTypeId.Text);
            Crud oCrud = new Crud();
            oCrud.DeleteType(nTypeId);

            this.FormDeleteTypes.dataGridViewTypes.DataSource = oCrud.GetAllTypes();
            this.Hide();
        }

        private void btnDeleteTypeClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
