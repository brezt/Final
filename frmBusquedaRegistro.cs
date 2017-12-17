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
    public partial class frmBusquedaRegistro : Form
    {
        public frmBusquedaRegistro()
        {
            InitializeComponent();
        }

        private void frmBusquedaRegistro_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
             dgvRegistros.DataSource= op.ConsultaConResultado("select registro.id_registro, empleado.Nombre, empleado.Apellido, nivel_academico.Nivel, cargo.descri_cargo, estudio_extras.Desc_estdios, registro.para_pension, registro.para_juvilacion, registro.fecha  from registro inner join  empleado on empleado.id_empleado = registro.id_empleado inner join nivel_academico on nivel_academico.Id_nivel_acad = registro.id_nivel_acad inner join cargo on cargo.id_cargo = registro.id_cargo inner join estudio_extras on estudio_extras.id_estudio_ex = registro.id_estudio_ex");
        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
