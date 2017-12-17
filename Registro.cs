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
    public partial class Registro : Form
    {

        string ingreso_minerd = "";

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();

           // DataGridViewRow rellenar = dgvRegistros.Rows[e.RowIndex];
            dgvRegistros.DataSource = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad");

           
        }

        private void btngeneralegistr_Click(object sender, EventArgs e)
        {

            Operaciones op = new Operaciones();

            dgvRegistros.DataSource = op.ConsultaConResultado("select empleado.id_empleado, empleado.Nombre, empleado.Apellido, empleado.Cedula, empleado.Nacionalidad, empleado.celular, empleado.Direccion, empleado.Telefono, empleado.Correo, empleado.Estado_civil, empleado.Fecha_ing_minerd, empleado.Estatus, empleado.Nacionalidad, empleado.nacimiento, empleado.sexo, cargo.descri_cargo as Cargos, Estudio_extras.Desc_estdios Estudios_Extras, nivel_academico.Nivel, Empleado.foto from empleado inner join cargo on empleado.Id_cargo = cargo.Id_cargo inner join estudio_extras on empleado.Id_estudio_ex = estudio_extras.id_estudio_ex inner join nivel_academico on empleado.id_nivel_acad = nivel_academico.Id_nivel_acad");

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtIdRegistro.Text != "".Trim())
            {
                //ojo me estan calculando bien las fechas
                for (int s = 1; s < dgvRegistros.Rows.Count - 1; s++)
                {
                    Operaciones op = new Operaciones();
                    string ingreso_minerd = "";

                    ingreso_minerd = dgvRegistros.Rows[s].Cells["Fecha_ing_minerd"].Value.ToString();
                    string nombre = dgvRegistros.Rows[s].Cells["Nombre"].Value.ToString();
                    string nivelAcademico = dgvRegistros.Rows[s].Cells["Nivel"].Value.ToString();
                    string cargo = dgvRegistros.Rows[s].Cells["Cargos"].Value.ToString();
                    string estudiosExtras = dgvRegistros.Rows[s].Cells["Estudios_extras"].Value.ToString();
                    string id_empleado = dgvRegistros.Rows[s].Cells["id_empleado"].Value.ToString();

                    // string id_empleado=
                    DateTime a = Convert.ToDateTime(ingreso_minerd);
                    int anosTrabajando = DateTime.Today.AddTicks(-a.Ticks).Year - 1;



                    /// empleado para pension y no de jubilacion 
                    if ((anosTrabajando >=25) && (anosTrabajando < 30))
                    {
                        op.ConsultaConResultado(" insert into Registro  (fecha, id_registro, id_empleado, id_nivel_acad, id_cargo, id_estudio_ex, para_juvilacion, para_pension) select   '"+txtFecha.Text+"','" + txtIdRegistro.Text + "', empleado.id_empleado, empleado.id_nivel_acad, empleado.Id_cargo, empleado.Id_estudio_ex, 'no', 'si' from empleado  where empleado.id_empleado ='" + dgvRegistros.Rows[s].Cells["id_empleado"].Value.ToString() + "'");
                    }

                    else if (anosTrabajando >= 30)
                    {
                        op.ConsultaConResultado(" insert into Registro  (fecha, id_registro, id_empleado, id_nivel_acad, id_cargo, id_estudio_ex, para_juvilacion, para_pension) select '"+txtFecha.Text+"','" + txtIdRegistro.Text + "', empleado.id_empleado, empleado.id_nivel_acad, empleado.Id_cargo, empleado.Id_estudio_ex, 'si', 'no' from empleado  where empleado.id_empleado ='" + dgvRegistros.Rows[s].Cells["id_empleado"].Value.ToString() + "'");

                    }

                    else
                    {
                        op.ConsultaConResultado(" insert into Registro  (fecha, id_registro, id_empleado, id_nivel_acad, id_cargo, id_estudio_ex, para_juvilacion, para_pension) select  '"+txtFecha.Text+"','" + txtIdRegistro.Text + "', empleado.id_empleado, empleado.id_nivel_acad, empleado.Id_cargo, empleado.Id_estudio_ex, 'no', 'no' from empleado  where empleado.id_empleado ='" + dgvRegistros.Rows[s].Cells["id_empleado"].Value.ToString() + "'");

                    }
                    // txtedad.Text = Convert.ToString(edad + "  AÑOS DE EDAD");
                    // MessageBox.Show( Convert.ToString( anosTrabajando) );
                }
                MessageBox.Show("Datos Guardados");
            }
            else
            {
                MessageBox.Show("Por favor escriba un numero de registro");
                txtIdRegistro.Focus();
            }
        }
    }
}
