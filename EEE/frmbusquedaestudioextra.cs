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
    public partial class frmbusquedaestudioextra : Form
    {
        public frmbusquedaestudioextra()
        {
            InitializeComponent();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnestudiextra.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvestudioextra.DataSource = op.ConsultaConResultado("select * from Estudio_extras where Desc_estdios like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvestudioextra.DataSource = op.ConsultaConResultado("select * from Estdio_extras where id_extudio_ex like '%" + txtBuscar.Text + "%'");
            }
        }

        private void dgvestudioextra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones op = new Operaciones();
            estudio_extra emp = new estudio_extra();
            DataGridViewRow rellenar = dgvestudioextra.Rows[e.RowIndex];

            emp.txtestudioex.Text = rellenar.Cells["desc_estdios"].Value.ToString();
            //emp.txtidcargo.Text = rellenar.Cells["id_cargo"].Value.ToString();
            emp.Show();
        }
    }
}
