namespace EEE
{
    partial class frmEmpleadoDesdeHasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoDesdeHasta));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFechaFinal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Fecha Inicial";
            // 
            // txtFechaInicial
            // 
            this.txtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaInicial.Location = new System.Drawing.Point(133, 84);
            this.txtFechaInicial.Name = "txtFechaInicial";
            this.txtFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.txtFechaInicial.TabIndex = 27;
            // 
            // dgvempleado
            // 
            this.dgvempleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(20, 127);
            this.dgvempleado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.RowTemplate.Height = 24;
            this.dgvempleado.Size = new System.Drawing.Size(878, 353);
            this.dgvempleado.TabIndex = 26;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(806, 63);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(92, 54);
            this.btnimprimir.TabIndex = 25;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(679, 63);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(94, 54);
            this.bntBuscar.TabIndex = 24;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "visualizador de empleados que entraron en un rango de dos fechas ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Fecha Final";
            // 
            // txtFechaFinal
            // 
            this.txtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaFinal.Location = new System.Drawing.Point(367, 84);
            this.txtFechaFinal.Name = "txtFechaFinal";
            this.txtFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.txtFechaFinal.TabIndex = 30;
            // 
            // frmEmpleadoDesdeHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFechaFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFechaInicial);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Name = "frmEmpleadoDesdeHasta";
            this.Text = "frmEmpleadoDesdeHasta";
            this.Load += new System.EventHandler(this.frmEmpleadoDesdeHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtFechaInicial;
        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtFechaFinal;
    }
}