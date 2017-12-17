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
    public partial class jubilacion : Form
    {
        public jubilacion()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtjubilacion.Text == "")
            {

                MessageBox.Show("Por favor escriba Años minimo para la jubilación");


            }
            //Conexion a la Base de Datos//
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into Jubilacion(anos_jubilacion) values('" + txtjubilacion.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtjubilacion.Text = "";
            }
        }
    }
}
