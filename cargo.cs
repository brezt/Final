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
    public partial class cargo : Form
    {
        public cargo()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtdescripcargo.Text == "")
            {

                MessageBox.Show("Por favor escriba el Cargo");


            }
            //Conexion a la Base de Datos//
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into Cargo(descri_cargo) values('" + txtdescripcargo.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtdescripcargo.Text = "";
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

        }
    }
}
