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
    public partial class FormEditType : Form
    {
        private readonly Form1 FormEditTypes;
        public FormEditType(Form1 FormEditT)
        {
            FormEditTypes = FormEditT;
            InitializeComponent();
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            Trace.WriteLine(inptEditTypeName.Text);
            Types oType = new Types();
            oType.nTypeID = Int32.Parse(lblTypeId.Text);
            oType.sTypeName = inptEditTypeName.Text;
            oType.sTypeValue = inptEditTypeValue.Text;
            Crud oCrud = new Crud();
            oCrud.UpdateType(oType);


            this.FormEditTypes.dataGridViewTypes.DataSource = oCrud.GetAllTypes();
            this.Hide();
        }
    }
}
