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
                dgvestudioextra.DataSource = op.ConsultaConResultado("select * from Estudio_extras where Desc_estudios like '%" + txtBuscar.Text + "%'");
            }

            else if (rbtnId.Checked == true)
            {
                Operaciones op = new Operaciones();
                dgvestudioextra.DataSource = op.ConsultaConResultado("select * from Estudio_extras where id_extudio_ex like '%" + txtBuscar.Text + "%'");
            }
        }
    }
}
