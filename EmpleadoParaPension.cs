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
    public partial class EmpleadoParaPension : Form
    {
        public EmpleadoParaPension()
        {
            InitializeComponent();
        }

        private void EmpleadoParaPension_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

            dgvempleado.DataSource = op.ConsultaConResultado("select registro.id_registro, empleado.Nombre, empleado.Apellido, nivel_academico.Nivel, cargo.descri_cargo, estudio_extras.Desc_estdios  from registro inner join  empleado on empleado.id_empleado = registro.id_empleado inner join nivel_academico on nivel_academico.Id_nivel_acad = registro.id_nivel_acad inner join cargo on cargo.id_cargo = registro.id_cargo inner join estudio_extras on estudio_extras.id_estudio_ex = registro.id_estudio_ex where registro.para_pension= 'si'");


        }

        private void dgvempleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            DataSet ds = new DataSet();



            DataTable dt = op.ConsultaConResultado("select registro.id_registro, empleado.Nombre, empleado.Apellido, nivel_academico.Nivel, cargo.descri_cargo, estudio_extras.Desc_estdios  from registro inner join  empleado on empleado.id_empleado = registro.id_empleado inner join nivel_academico on nivel_academico.Id_nivel_acad = registro.id_nivel_acad inner join cargo on cargo.id_cargo = registro.id_cargo inner join estudio_extras on estudio_extras.id_estudio_ex = registro.id_estudio_ex where registro.para_pension= 'si'");

            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "Registro";
            ds.WriteXml(@"C:\sistema\empleadoParaPension.xml");

        }
    }
}
