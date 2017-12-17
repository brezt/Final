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
    public partial class Incio : Form
    {
        public Incio()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Inicio_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            frmBusquedaEmpleado be = new frmBusquedaEmpleado();
            be.Show();
        }

        private void btncargo_Click(object sender, EventArgs e)
        {
            frmBusquedaCargo bc = new frmBusquedaCargo();
            bc.Show();
        }

        private void btnnivel_Click(object sender, EventArgs e)
        {
            frmBusquedaNivelAcademico ba = new frmBusquedaNivelAcademico();
            ba.Show();
        }

        private void bntregistro_Click(object sender, EventArgs e)
        {
            frmBusquedaRegistro br = new frmBusquedaRegistro();
            br.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEmpleado emp = new frmEmpleado();
            emp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cargo ca = new cargo();
            ca.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nivel_academico na = new nivel_academico();
            na.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            estudio_extra ee = new estudio_extra();
            ee.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jubilacion jub = new jubilacion();
            jub.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pension pen = new pension();
            pen.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMantenimientoUsuarios mu = new frmMantenimientoUsuarios();
            mu.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmbusquedaestudioextra bc = new frmbusquedaestudioextra();
            bc.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            EmpleadoParaPension em = new EmpleadoParaPension();
            em.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            EmpleadoParaPension em = new EmpleadoParaPension();
            em.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmEmpleadoParaJubilacion em = new frmEmpleadoParaJubilacion();
            em.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            frmEmpleadoDesdeHasta em = new frmEmpleadoDesdeHasta();
            em.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            frmEmpleadoPorFecha em = new frmEmpleadoPorFecha();
            em.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
