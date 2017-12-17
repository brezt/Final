namespace EEE
{
    partial class frmBusquedaEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaEmpleado));
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.rbtncedula = new System.Windows.Forms.RadioButton();
            this.rbtnapellido = new System.Windows.Forms.RadioButton();
            this.rbtnnombre = new System.Windows.Forms.RadioButton();
            this.rbtnid = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvempleado
            // 
            this.dgvempleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(11, 111);
            this.dgvempleado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.RowTemplate.Height = 24;
            this.dgvempleado.Size = new System.Drawing.Size(878, 467);
            this.dgvempleado.TabIndex = 16;
            this.dgvempleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvempleado_CellDoubleClick);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(797, 9);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(92, 54);
            this.btnimprimir.TabIndex = 15;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(699, 8);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(94, 54);
            this.bntBuscar.TabIndex = 14;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(297, 27);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(387, 20);
            this.txtbuscar.TabIndex = 13;
            // 
            // rbtncedula
            // 
            this.rbtncedula.AutoSize = true;
            this.rbtncedula.Location = new System.Drawing.Point(214, 18);
            this.rbtncedula.Margin = new System.Windows.Forms.Padding(2);
            this.rbtncedula.Name = "rbtncedula";
            this.rbtncedula.Size = new System.Drawing.Size(58, 17);
            this.rbtncedula.TabIndex = 12;
            this.rbtncedula.TabStop = true;
            this.rbtncedula.Text = "Cédula";
            this.rbtncedula.UseVisualStyleBackColor = true;
            // 
            // rbtnapellido
            // 
            this.rbtnapellido.AutoSize = true;
            this.rbtnapellido.Location = new System.Drawing.Point(134, 18);
            this.rbtnapellido.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnapellido.Name = "rbtnapellido";
            this.rbtnapellido.Size = new System.Drawing.Size(62, 17);
            this.rbtnapellido.TabIndex = 11;
            this.rbtnapellido.TabStop = true;
            this.rbtnapellido.Text = "Apellido";
            this.rbtnapellido.UseVisualStyleBackColor = true;
            // 
            // rbtnnombre
            // 
            this.rbtnnombre.AutoSize = true;
            this.rbtnnombre.Location = new System.Drawing.Point(56, 18);
            this.rbtnnombre.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnnombre.Name = "rbtnnombre";
            this.rbtnnombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnnombre.TabIndex = 10;
            this.rbtnnombre.TabStop = true;
            this.rbtnnombre.Text = "Nombre";
            this.rbtnnombre.UseVisualStyleBackColor = true;
            // 
            // rbtnid
            // 
            this.rbtnid.AutoSize = true;
            this.rbtnid.Location = new System.Drawing.Point(3, 18);
            this.rbtnid.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnid.Name = "rbtnid";
            this.rbtnid.Size = new System.Drawing.Size(33, 17);
            this.rbtnid.TabIndex = 9;
            this.rbtnid.TabStop = true;
            this.rbtnid.Text = "id";
            this.rbtnid.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnnombre);
            this.groupBox1.Controls.Add(this.rbtnid);
            this.groupBox1.Controls.Add(this.rbtnapellido);
            this.groupBox1.Controls.Add(this.rbtncedula);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 51);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(480, 53);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Actualizar ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmBusquedaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(908, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Name = "frmBusquedaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaEmpleado";
            this.Load += new System.EventHandler(this.frmBusquedaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rbtncedula;
        private System.Windows.Forms.RadioButton rbtnapellido;
        private System.Windows.Forms.RadioButton rbtnnombre;
        private System.Windows.Forms.RadioButton rbtnid;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.Button button1;
    }
}