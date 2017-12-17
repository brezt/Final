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
    public partial class estudio_extra : Form
    {
        public estudio_extra()
        {
            InitializeComponent();
        }

        private void btncrear_Click(object sender, EventArgs e)
        {
            if (txtestudioex.Text == "")
            {

                MessageBox.Show("Por favor escriba en Estudio Extras");


            }
            //Conexion a la Base de Datos//
            else
            {
                Operaciones op = new Operaciones();
                op.ConsultasSinResultados("insert into Estudio_extras(Desc_estudios) values('" + txtestudioex.Text + "')");
                MessageBox.Show("DATOS GUARDADOS");
                txtestudioex.Text = "";
            }
        }
    }
}
