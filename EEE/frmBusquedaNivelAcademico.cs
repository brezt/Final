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
    public partial class frmBusquedaNivelAcademico : Form
    {
        public frmBusquedaNivelAcademico()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones op = new Operaciones();
            nivel_academico emp = new nivel_academico();
            DataGridViewRow rellenar = dgvnivelacad.Rows[e.RowIndex];

            emp.txtnivel.Text = rellenar.Cells["Nivel"].Value.ToString();
            //emp.txtidcargo.Text = rellenar.Cells["id_cargo"].Value.ToString();
            emp.Show();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnNivel.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvnivelacad.DataSource = op.ConsultaConResultado("select * from Nivel_academico where nivel like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvnivelacad.DataSource = op.ConsultaConResultado("select * from Nivel_academico where Id_nivel_acad like '%" + txtBuscar.Text + "%'");
            }
        }

        private void frmBusquedaNivelAcademico_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            dgvnivelacad.DataSource = op.ConsultaConResultado("select * from Nivel_academico");

        }
    }
}
