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
    public partial class nivel_academico : Form
    {
        public nivel_academico()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtnivel.Text == "")
            {

                MessageBox.Show("Por favor escriba el Nivel Academico");


            }
            //Conexion a la Base de Datos//
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into Nivel_academico(Nivel) values('" + txtnivel.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtnivel.Text = "";
            }
        }
    }
}
