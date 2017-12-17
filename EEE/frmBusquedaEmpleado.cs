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
    public partial class frmBusquedaEmpleado : Form
    {
        public frmBusquedaEmpleado()
        {
            InitializeComponent();
        }

        private void frmBusquedaEmpleado_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            dgvempleado.DataSource= op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad");
           // dgvempleado.DataSource = op.ConsultaConResultado("select * from empleado");
            
        }

        private void dgvempleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones op = new Operaciones();
            frmEmpleado emp = new frmEmpleado();
            DataGridViewRow rellenar = dgvempleado.Rows[e.RowIndex];
                      
            emp.cmbestado.Text = rellenar.Cells["Estatus"].Value.ToString();          
            emp.txtnombre.Text = rellenar.Cells["Nombre"].Value.ToString();
            emp.txtapellido.Text = rellenar.Cells["Apellido"].Value.ToString();
            emp.txtcedula.Text = rellenar.Cells["Cedula"].Value.ToString();
            emp.txtNacionalidad.Text = rellenar.Cells["Nacionalidad"].Value.ToString();
            emp.txtdireccion.Text = rellenar.Cells["Direccion"].Value.ToString();
            emp.txttelefono.Text = rellenar.Cells["Telefono"].Value.ToString();
            emp.txtCorreo.Text = rellenar.Cells["Correo"].Value.ToString();
            emp.cmbEstadoCivil.Text = rellenar.Cells["Estado_civil"].Value.ToString();
            emp.txtid.Text = rellenar.Cells["id_empleado"].Value.ToString();
            emp.cmbcargo.Text = rellenar.Cells["Cargos"].Value.ToString();
            emp.cmbEstudiosExtras.Text = rellenar.Cells["Estudios_Extras"].Value.ToString();
            emp.cmbNivelAcademico.Text = rellenar.Cells["Nivel"].Value.ToString();

            emp.txtRuta.Text = rellenar.Cells["foto"].Value.ToString();
            emp.txtNacimiento.Text = rellenar.Cells["nacimiento"].Value.ToString();
            emp.txtCelular.Text = rellenar.Cells["celular"].Value.ToString();
            emp.cmbsexo.Text = rellenar.Cells["sexo"].Value.ToString();

            OpenFileDialog OP = new OpenFileDialog();
            string f = emp.procesar(rellenar.Cells["foto"].Value.ToString());

            if (!f.Equals(""))
            {
                emp.pictureBox1.Load(f.ToString());
            }


            emp.Show();

        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            dgvempleado.DataSource = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad");

        }
    }
}
