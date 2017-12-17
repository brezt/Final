using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EEE
{
    public partial class frmBusquedaCargo : Form
    {
        public frmBusquedaCargo()
        {
            InitializeComponent();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnestudi.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from Cargo where descri_cargo like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvcargo.DataSource = op.ConsultaConResultado("select * from Cargo where id_cargo like '%" + txtBuscar.Text + "%'");
            }
        }

        private void frmBusquedaCargo_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            dgvcargo.DataSource = op.ConsultaConResultado("select * from Cargo");

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvcargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones op = new Operaciones();
            cargo emp = new  cargo();
            DataGridViewRow rellenar = dgvcargo.Rows[e.RowIndex];

            emp.txtdescripcargo.Text = rellenar.Cells["descri_cargo"].Value.ToString();
            emp.txtidcargo.Text = rellenar.Cells["id_cargo"].Value.ToString();
            emp.Show();
        }
    }
}
