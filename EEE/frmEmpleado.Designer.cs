namespace EEE
{
    partial class frmEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleado));
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.frmcrearempleado = new System.Windows.Forms.GroupBox();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdNivelAcademico = new System.Windows.Forms.TextBox();
            this.cmbNivelAcademico = new System.Windows.Forms.ComboBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.txtIdEstudiosExtras = new System.Windows.Forms.TextBox();
            this.txtidcargo = new System.Windows.Forms.TextBox();
            this.btnimagen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.lbnestado = new System.Windows.Forms.Label();
            this.cmbEstudiosExtras = new System.Windows.Forms.ComboBox();
            this.lbndepartamento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbcargo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbntelefono = new System.Windows.Forms.Label();
            this.lbndireccion = new System.Windows.Forms.Label();
            this.lbncedula = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.frmcrearempleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(406, 432);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(118, 39);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(278, 429);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(119, 39);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncrear
            // 
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(166, 428);
            this.btncrear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(107, 39);
            this.btncrear.TabIndex = 7;
            this.btncrear.Text = "Crear";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // frmcrearempleado
            // 
            this.frmcrearempleado.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.frmcrearempleado.Controls.Add(this.cmbEstadoCivil);
            this.frmcrearempleado.Controls.Add(this.label12);
            this.frmcrearempleado.Controls.Add(this.txtIngreso);
            this.frmcrearempleado.Controls.Add(this.txtNacimiento);
            this.frmcrearempleado.Controls.Add(this.txtNacionalidad);
            this.frmcrearempleado.Controls.Add(this.label10);
            this.frmcrearempleado.Controls.Add(this.txtCelular);
            this.frmcrearempleado.Controls.Add(this.label9);
            this.frmcrearempleado.Controls.Add(this.txtCorreo);
            this.frmcrearempleado.Controls.Add(this.label8);
            this.frmcrearempleado.Controls.Add(this.txtIdNivelAcademico);
            this.frmcrearempleado.Controls.Add(this.cmbNivelAcademico);
            this.frmcrearempleado.Controls.Add(this.txtRuta);
            this.frmcrearempleado.Controls.Add(this.txtIdEstudiosExtras);
            this.frmcrearempleado.Controls.Add(this.txtidcargo);
            this.frmcrearempleado.Controls.Add(this.btnimagen);
            this.frmcrearempleado.Controls.Add(this.label7);
            this.frmcrearempleado.Controls.Add(this.txtid);
            this.frmcrearempleado.Controls.Add(this.txtdescripcion);
            this.frmcrearempleado.Controls.Add(this.cmbestado);
            this.frmcrearempleado.Controls.Add(this.lbnestado);
            this.frmcrearempleado.Controls.Add(this.cmbEstudiosExtras);
            this.frmcrearempleado.Controls.Add(this.lbndepartamento);
            this.frmcrearempleado.Controls.Add(this.label6);
            this.frmcrearempleado.Controls.Add(this.pictureBox1);
            this.frmcrearempleado.Controls.Add(this.cmbcargo);
            this.frmcrearempleado.Controls.Add(this.label5);
            this.frmcrearempleado.Controls.Add(this.cmbsexo);
            this.frmcrearempleado.Controls.Add(this.txttelefono);
            this.frmcrearempleado.Controls.Add(this.txtcedula);
            this.frmcrearempleado.Controls.Add(this.txtdireccion);
            this.frmcrearempleado.Controls.Add(this.lbntelefono);
            this.frmcrearempleado.Controls.Add(this.lbndireccion);
            this.frmcrearempleado.Controls.Add(this.lbncedula);
            this.frmcrearempleado.Controls.Add(this.txtapellido);
            this.frmcrearempleado.Controls.Add(this.txtnombre);
            this.frmcrearempleado.Controls.Add(this.label4);
            this.frmcrearempleado.Controls.Add(this.label3);
            this.frmcrearempleado.Controls.Add(this.label2);
            this.frmcrearempleado.Controls.Add(this.Apellido);
            this.frmcrearempleado.Controls.Add(this.label1);
            this.frmcrearempleado.Location = new System.Drawing.Point(9, 62);
            this.frmcrearempleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmcrearempleado.Name = "frmcrearempleado";
            this.frmcrearempleado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.frmcrearempleado.Size = new System.Drawing.Size(895, 353);
            this.frmcrearempleado.TabIndex = 6;
            this.frmcrearempleado.TabStop = false;
            this.frmcrearempleado.Text = "Datos Generales";
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Soltero(a)",
            "Divorciado(a)",
            "Unión Libre"});
            this.cmbEstadoCivil.Location = new System.Drawing.Point(446, 209);
            this.cmbEstadoCivil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(238, 21);
            this.cmbEstadoCivil.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(379, 214);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Estado Civil";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtIngreso.Location = new System.Drawing.Point(446, 75);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(236, 20);
            this.txtIngreso.TabIndex = 48;
            // 
            // txtNacimiento
            // 
            this.txtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNacimiento.Location = new System.Drawing.Point(446, 48);
            this.txtNacimiento.Name = "txtNacimiento";
            this.txtNacimiento.Size = new System.Drawing.Size(236, 20);
            this.txtNacimiento.TabIndex = 47;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(68, 210);
            this.txtNacionalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(237, 20);
            this.txtNacionalidad.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 214);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "Nacionalidad";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(68, 126);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelular.Mask = "000-000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(237, 20);
            this.txtCelular.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Celular:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(68, 180);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(237, 20);
            this.txtCorreo.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Correo";
            // 
            // txtIdNivelAcademico
            // 
            this.txtIdNivelAcademico.Location = new System.Drawing.Point(659, 183);
            this.txtIdNivelAcademico.Name = "txtIdNivelAcademico";
            this.txtIdNivelAcademico.Size = new System.Drawing.Size(25, 20);
            this.txtIdNivelAcademico.TabIndex = 40;
            // 
            // cmbNivelAcademico
            // 
            this.cmbNivelAcademico.FormattingEnabled = true;
            this.cmbNivelAcademico.Location = new System.Drawing.Point(446, 183);
            this.cmbNivelAcademico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNivelAcademico.Name = "cmbNivelAcademico";
            this.cmbNivelAcademico.Size = new System.Drawing.Size(209, 21);
            this.cmbNivelAcademico.TabIndex = 39;
            this.cmbNivelAcademico.SelectedIndexChanged += new System.EventHandler(this.cmbNivelAcademico_SelectedIndexChanged);
            this.cmbNivelAcademico.TextChanged += new System.EventHandler(this.cmbNivelAcademico_TextChanged);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(748, 306);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(102, 20);
            this.txtRuta.TabIndex = 38;
            // 
            // txtIdEstudiosExtras
            // 
            this.txtIdEstudiosExtras.Location = new System.Drawing.Point(659, 152);
            this.txtIdEstudiosExtras.Name = "txtIdEstudiosExtras";
            this.txtIdEstudiosExtras.Size = new System.Drawing.Size(25, 20);
            this.txtIdEstudiosExtras.TabIndex = 36;
            // 
            // txtidcargo
            // 
            this.txtidcargo.Location = new System.Drawing.Point(659, 126);
            this.txtidcargo.Name = "txtidcargo";
            this.txtidcargo.Size = new System.Drawing.Size(25, 20);
            this.txtidcargo.TabIndex = 6;
            // 
            // btnimagen
            // 
            this.btnimagen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnimagen.Image = ((System.Drawing.Image)(resources.GetObject("btnimagen.Image")));
            this.btnimagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimagen.Location = new System.Drawing.Point(746, 232);
            this.btnimagen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnimagen.Name = "btnimagen";
            this.btnimagen.Size = new System.Drawing.Size(104, 58);
            this.btnimagen.TabIndex = 35;
            this.btnimagen.Text = "Examinar ";
            this.btnimagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimagen.UseVisualStyleBackColor = false;
            this.btnimagen.Click += new System.EventHandler(this.btnimagen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(845, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(864, 8);
            this.txtid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(22, 20);
            this.txtid.TabIndex = 33;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.AutoSize = true;
            this.txtdescripcion.Location = new System.Drawing.Point(362, 185);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(81, 13);
            this.txtdescripcion.TabIndex = 31;
            this.txtdescripcion.Text = "Nivel Acadmico";
            this.txtdescripcion.Click += new System.EventHandler(this.txtdescripcion_Click);
            // 
            // cmbestado
            // 
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbestado.Location = new System.Drawing.Point(68, 153);
            this.cmbestado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(238, 21);
            this.cmbestado.TabIndex = 30;
            // 
            // lbnestado
            // 
            this.lbnestado.AutoSize = true;
            this.lbnestado.Location = new System.Drawing.Point(28, 153);
            this.lbnestado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbnestado.Name = "lbnestado";
            this.lbnestado.Size = new System.Drawing.Size(37, 13);
            this.lbnestado.TabIndex = 29;
            this.lbnestado.Text = "Status";
            // 
            // cmbEstudiosExtras
            // 
            this.cmbEstudiosExtras.FormattingEnabled = true;
            this.cmbEstudiosExtras.Location = new System.Drawing.Point(446, 152);
            this.cmbEstudiosExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbEstudiosExtras.Name = "cmbEstudiosExtras";
            this.cmbEstudiosExtras.Size = new System.Drawing.Size(209, 21);
            this.cmbEstudiosExtras.TabIndex = 28;
            this.cmbEstudiosExtras.SelectedIndexChanged += new System.EventHandler(this.cmbEstudiosExtras_SelectedIndexChanged);
            this.cmbEstudiosExtras.TextChanged += new System.EventHandler(this.cmbEstudiosExtras_TextChanged);
            // 
            // lbndepartamento
            // 
            this.lbndepartamento.AutoSize = true;
            this.lbndepartamento.Location = new System.Drawing.Point(361, 154);
            this.lbndepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbndepartamento.Name = "lbndepartamento";
            this.lbndepartamento.Size = new System.Drawing.Size(79, 13);
            this.lbndepartamento.TabIndex = 27;
            this.lbndepartamento.Text = "Estudios Extras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(753, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Fotografía";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(700, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // cmbcargo
            // 
            this.cmbcargo.FormattingEnabled = true;
            this.cmbcargo.Location = new System.Drawing.Point(446, 125);
            this.cmbcargo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbcargo.Name = "cmbcargo";
            this.cmbcargo.Size = new System.Drawing.Size(209, 21);
            this.cmbcargo.TabIndex = 24;
            this.cmbcargo.SelectedIndexChanged += new System.EventHandler(this.cmbcargo_SelectedIndexChanged);
            this.cmbcargo.TextChanged += new System.EventHandler(this.cmbcargo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cargo:";
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbsexo.Location = new System.Drawing.Point(68, 48);
            this.cmbsexo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(238, 21);
            this.cmbsexo.TabIndex = 22;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(68, 99);
            this.txttelefono.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttelefono.Mask = "000-000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(236, 20);
            this.txttelefono.TabIndex = 19;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(68, 73);
            this.txtcedula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcedula.Mask = "000-000000-0";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(238, 20);
            this.txtcedula.TabIndex = 18;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(446, 101);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(236, 20);
            this.txtdireccion.TabIndex = 15;
            // 
            // lbntelefono
            // 
            this.lbntelefono.AutoSize = true;
            this.lbntelefono.Location = new System.Drawing.Point(14, 103);
            this.lbntelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbntelefono.Name = "lbntelefono";
            this.lbntelefono.Size = new System.Drawing.Size(52, 13);
            this.lbntelefono.TabIndex = 14;
            this.lbntelefono.Text = "Telefono:";
            // 
            // lbndireccion
            // 
            this.lbndireccion.AutoSize = true;
            this.lbndireccion.Location = new System.Drawing.Point(386, 103);
            this.lbndireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbndireccion.Name = "lbndireccion";
            this.lbndireccion.Size = new System.Drawing.Size(55, 13);
            this.lbndireccion.TabIndex = 12;
            this.lbndireccion.Text = "Dirección:";
            // 
            // lbncedula
            // 
            this.lbncedula.AutoSize = true;
            this.lbncedula.Location = new System.Drawing.Point(22, 73);
            this.lbncedula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbncedula.Name = "lbncedula";
            this.lbncedula.Size = new System.Drawing.Size(43, 13);
            this.lbncedula.TabIndex = 10;
            this.lbncedula.Text = "Cédula:";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(446, 21);
            this.txtapellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(236, 20);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(68, 20);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(237, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Ingreso MINERD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sexo";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(394, 26);
            this.Apellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(44, 13);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(858, 20);
            this.lblusuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(42, 13);
            this.lblusuario.TabIndex = 13;
            this.lblusuario.Text = "ADMIN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(804, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label13.Location = new System.Drawing.Point(274, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 26);
            this.label13.TabIndex = 25;
            this.label13.Text = "CREAR EMPLEADO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(913, 482);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.frmcrearempleado);
            this.Name = "frmEmpleado";
            this.Text = "frmEmpleado";
            this.Load += new System.EventHandler(this.frmEmpleado_Load);
            this.frmcrearempleado.ResumeLayout(false);
            this.frmcrearempleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtRuta;
        public System.Windows.Forms.TextBox txtIdEstudiosExtras;
        public System.Windows.Forms.TextBox txtidcargo;
        private System.Windows.Forms.Button btnimagen;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label txtdescripcion;
        public System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label lbnestado;
        public System.Windows.Forms.ComboBox cmbEstudiosExtras;
        private System.Windows.Forms.Label lbndepartamento;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cmbcargo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox cmbsexo;
        public System.Windows.Forms.MaskedTextBox txttelefono;
        public System.Windows.Forms.MaskedTextBox txtcedula;
        public System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbntelefono;
        private System.Windows.Forms.Label lbndireccion;
        private System.Windows.Forms.Label lbncedula;
        public System.Windows.Forms.TextBox txtapellido;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtIdNivelAcademico;
        public System.Windows.Forms.ComboBox cmbNivelAcademico;
        public System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.Button btncrear;
        public System.Windows.Forms.GroupBox frmcrearempleado;
        public System.Windows.Forms.DateTimePicker txtIngreso;
        public System.Windows.Forms.DateTimePicker txtNacimiento;
        private System.Windows.Forms.Label label13;
    }
}