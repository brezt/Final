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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR NIVEL ACADEMICO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Operaciones op = new Operaciones();
            op.ConsultasSinResultados("UPDATE Nivel_academico SET Nivel ='" + txtnivel.Text + "'where Id_nivel_acad = '" + txtIdNivelAcademico.Text + "'");

        }
    }
}
