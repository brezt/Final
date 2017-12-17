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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        string foto = "";

        private void btnimagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\sistemas";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png|GIF (*.gif)|*.gif";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = getImage.FileName;
                txtRuta.Text = getImage.FileName;
                foto = procesar(getImage.FileName.ToString());

                pictureBox1.Load(foto);
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna imagen", "Sin seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void borrar()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtcedula.Clear();
            txtCorreo.Clear();
            txtdireccion.Clear();
            txtcedula.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtCelular.Clear();
            txtid.Clear();
            txtidcargo.Clear();
            txtIdEstudiosExtras.Clear();
            txtIdNivelAcademico.Clear();
            txtNacionalidad.Clear();
            cmbcargo.Items.Clear();
            cmbestado.Items.Clear();
            cmbEstadoCivil.Items.Clear();
            cmbEstudiosExtras.Items.Clear();
            cmbsexo.Items.Clear();
            cmbNivelAcademico.Items.Clear();
        }
        public string procesar(string x)
        {
            string[] separators = { "\\" };
            string[] palabras = x.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string texto = "";
            for (int a = 0; a < palabras.Length; a++)
            {
                texto += palabras[a];
                texto += (a < palabras.Length - 1) ? "\\\\" : "";
            }
            return texto;
        }

    

    private void btncrear_Click(object sender, EventArgs e)
    {
        if (validarcampos())
        {
            Operaciones op = new Operaciones();
            op.ConsultaConResultado("insert into Empleado (Nombre, Apellido, Cedula, Nacionalidad, Direccion, Telefono, Correo, Estado_civil, Fecha_ing_minerd, Id_cargo, id_estudio_ex, id_nivel_acad, Estatus, nacimiento, foto, celular, sexo, Estado_civil)values('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txttelefono.Text + "','" + txtNacionalidad.Text + "', '" + txtdireccion.Text + "','" + txttelefono.Text + "', '" + txtCorreo.Text + "', '" + cmbestado.Text + "', '" + txtIngreso.Text + "', '" + txtidcargo.Text + "', '" + txtIdEstudiosExtras.Text + "', '" + txtIdNivelAcademico.Text + "', '" + cmbestado.Text + "', '" + txtNacimiento.Text + "', '" + txtRuta.Text + "', '" + txtCelular.Text + "', '" + cmbsexo.Text + "', '" + cmbEstadoCivil.Text + "');");
                MessageBox.Show("DATOS CREADO");
                borrar();
            }
    }

    private Boolean validarcampos()
    {
        if (txtnombre.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR ESCRIBA EL NOMBRE", "ESCRIBIR NOMBRE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtnombre.Focus();
            return false;

        }
        if (txtapellido.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR ESCRIBA EL APELLIDO", "ESCRIBIR APELLIDO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtapellido.Focus();
            return false;

        }
        if (cmbsexo.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR ESCRIBA EL SEXO", "ESCRIBIR SEXO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbsexo.Focus();
            return false;

        }

        if (txtcedula.Text == "   -      -")
        {
            MessageBox.Show("POR FAVOR ESCRIBA LA CEDULA DE IDENTIDAD", "ESCRIBIR CEDULA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtcedula.Focus();
            return false;

        }
        if (txtdireccion.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR ESCRIBA LA DIRECCION", "ESCRIBIR LA DIRECCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtdireccion.Focus();
            return false;

        }

        if (cmbcargo.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR SELECCIONE EL CARGO", "SELECCIONAR CARGO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbcargo.Focus();
            return false;

        }

        if (cmbestado.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR SELECCIONE EL STATUS", "SELECCIONAR STATUS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbestado.Focus();
            return false;

        }

        if (cmbEstadoCivil.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR SELECCIONE EL ESTADO CIVIL", "SELECCIONAR ESTADO CIVIL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cmbEstadoCivil.Focus();
            return false;

        }

        if (txtNacionalidad.Text == "".Trim())
        {
            MessageBox.Show("POR FAVOR ESCRIBA LA NACIONALIDAD", "ESCRIBIR NACIONALIDAD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNacionalidad.Focus();
            return false;

        }

            if (cmbNivelAcademico.Text == "".Trim())
            {
                MessageBox.Show("POR FAVOR SELECCIONE EL NIVEL ACADEMICO", "SELECCIONAR NIVEL ACADEMICO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNacionalidad.Focus();
                return false;

            }
            else

            return true;



    }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.llenarComboBox(cmbcargo,"select descri_cargo from cargo", "descri_cargo");

            op.llenarComboBox(cmbEstudiosExtras, "select Desc_estdios from Estudio_extras", "Desc_estdios");

            op.llenarComboBox(cmbNivelAcademico, "select Nivel from Nivel_academico", "Nivel");
        }

        private void cmbcargo_TextChanged(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            
        }

        private void cmbcargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.llenarTextBox(txtidcargo, "select id_cargo from Cargo where descri_cargo like '%"+cmbcargo.Text+"%'", "id_cargo");

        }

        private void cmbEstudiosExtras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.llenarTextBox(txtIdEstudiosExtras, "select id_estudio_ex from Estudio_extras where Desc_estdios like '%" + cmbEstudiosExtras.Text+ "%'", "id_estudio_ex");

        }

        private void cmbNivelAcademico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.llenarTextBox(txtIdNivelAcademico, "select Id_nivel_acad from Nivel_academico where Nivel like '%" + cmbNivelAcademico.Text + "%'", "Id_nivel_acad");

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("SEGURO QUE DECEA MODIFICAR ESTE REGISTRO?", "ACTUALIZAR EMPLEADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) ;
            Operaciones op = new Operaciones();
            // op.ConsultasSinResultados("UPDATE Empleado SET Nombre ='" + txtnombre.Text + "', Apellido = '" + txtapellido.Text + "', Sexo = '" + cmbsexo.Text + "', nacimiento = '" + txtNacimiento.Text + "', Fecha_ing_minerd = '" + txtIngreso.Text + "', Cedula = '" + txtcedula.Text + "', Direccion = '" + txtdireccion.Text + "', Telefono = '" + txttelefono.Text + "', Celular = '" + txtCelular.Text + "', Id_cargo = '" + cmbcargo.Text + "', /////////////// = '" + txttelefono.Text + "', fechanacimiento = '" + txtfechanacimiento.Text + "', fechaingreso = '" + txtfechaingreso.Text + "', foto_empleado = '" + txtRuta.Text + "' WHERE idempleado = '" + txtid.Text + "' ");
            op.ConsultaConResultado(" UPDATE Empleado set Nombre, Apellido, Cedula, Nacionalidad, Direccion, Telefono, Correo, Estado_civil, Fecha_ing_minerd, Id_cargo, id_estudio_ex, id_nivel_acad, Estatus, nacimiento, foto, celular, sexo, Estado_civil)values('" + txtnombre.Text + "', '" + txtapellido.Text + "', '" + txttelefono.Text + "','" + txtNacionalidad.Text + "', '" + txtdireccion.Text + "','" + txttelefono.Text + "', '" + txtCorreo.Text + "', '" + cmbestado.Text + "', '" + txtIngreso.Text + "', '" + txtidcargo.Text + "', '" + txtIdEstudiosExtras.Text + "', '" + txtIdNivelAcademico.Text + "', '" + cmbestado.Text + "', '" + txtNacimiento.Text + "', '" + txtRuta.Text + "', '" + txtCelular.Text + "', '" + cmbsexo.Text + "', '" + cmbEstadoCivil.Text + "');");
            MessageBox.Show("DATOS CREADO");
            borrar();

        }

        private void txtdescripcion_Click(object sender, EventArgs e)
        {

        }
    }
}
