using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD;

namespace GooglePlaces
{
    public partial class FormAddType : Form
    {
        private readonly Form1 FormTypeList;
        public FormAddType(Form1 FormType)
        {
            FormTypeList = FormType;
            InitializeComponent();
        }

        private void btnAddType2_Click(object sender, EventArgs e)
        {
            Types oTypes = new Types();
            oTypes.sTypeName = inptAddTypeName.Text;
            oTypes.sTypeValue = inptAddTypeValue.Text;

            Crud oCrud = new Crud();
            oCrud.SaveNewType(oTypes);

            this.FormTypeList.dataGridViewTypes.DataSource = oCrud.GetAllTypes();
            this.Hide();
        }
    }
}
