namespace EEE
{
    partial class frmBusquedaRegistro
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
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.bntBuscar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.rbtnNumero = new System.Windows.Forms.RadioButton();
            this.tbtnFecha = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(32, 104);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowTemplate.Height = 24;
            this.dgvRegistros.Size = new System.Drawing.Size(827, 322);
            this.dgvRegistros.TabIndex = 25;
            this.dgvRegistros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellClick);
            // 
            // btnimprimir
            // 
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(761, 17);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(98, 54);
            this.btnimprimir.TabIndex = 24;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // bntBuscar
            // 
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(659, 17);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(98, 54);
            this.bntBuscar.TabIndex = 23;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(194, 35);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(448, 20);
            this.txtbuscar.TabIndex = 22;
            // 
            // rbtnNumero
            // 
            this.rbtnNumero.AutoSize = true;
            this.rbtnNumero.Location = new System.Drawing.Point(117, 35);
            this.rbtnNumero.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnNumero.Name = "rbtnNumero";
            this.rbtnNumero.Size = new System.Drawing.Size(60, 17);
            this.rbtnNumero.TabIndex = 20;
            this.rbtnNumero.TabStop = true;
            this.rbtnNumero.Text = "numero";
            this.rbtnNumero.UseVisualStyleBackColor = true;
            // 
            // tbtnFecha
            // 
            this.tbtnFecha.AutoSize = true;
            this.tbtnFecha.Location = new System.Drawing.Point(32, 35);
            this.tbtnFecha.Margin = new System.Windows.Forms.Padding(2);
            this.tbtnFecha.Name = "tbtnFecha";
            this.tbtnFecha.Size = new System.Drawing.Size(55, 17);
            this.tbtnFecha.TabIndex = 19;
            this.tbtnFecha.TabStop = true;
            this.tbtnFecha.Text = "Fecha";
            this.tbtnFecha.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Registros";
            // 
            // frmBusquedaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(949, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.bntBuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.rbtnNumero);
            this.Controls.Add(this.tbtnFecha);
            this.Name = "frmBusquedaRegistro";
            this.Text = "frmBusquedaRegistro";
            this.Load += new System.EventHandler(this.frmBusquedaRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.RadioButton rbtnNumero;
        private System.Windows.Forms.RadioButton tbtnFecha;
        private System.Windows.Forms.Label label2;
    }
}