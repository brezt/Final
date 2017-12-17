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
    public partial class frmEmpleadoDesdeHasta : Form
    {
        public frmEmpleadoDesdeHasta()
        {
            InitializeComponent();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {

            Operaciones op = new Operaciones();

            dgvempleado.DataSource = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad where Fecha_ing_minerd  between '"+txtFechaInicial.Text+"' and '"+txtFechaFinal.Text+ "'");

        }

        private void frmEmpleadoDesdeHasta_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            dgvempleado.DataSource = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad where Fecha_ing_minerd");

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            DataSet ds = new DataSet();



            DataTable dt = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad where Fecha_ing_minerd  between '" + txtFechaFinal.Text + "' and '" + txtFechaFinal.Text + "'");

            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "empleado";
            ds.WriteXml(@"C:\sistema\empleadoDesdeHasta.xml");

        }
    }
}
