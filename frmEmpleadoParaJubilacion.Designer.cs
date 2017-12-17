namespace EEE
{
    partial class frmEmpleadoParaJubilacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleadoParaJubilacion));
            this.dgvempleado = new System.Windows.Forms.DataGridView();
            this.btnimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvempleado
            // 
            this.dgvempleado.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvempleado.Location = new System.Drawing.Point(16, 64);
            this.dgvempleado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvempleado.Name = "dgvempleado";
            this.dgvempleado.RowTemplate.Height = 24;
            this.dgvempleado.Size = new System.Drawing.Size(625, 353);
            this.dgvempleado.TabIndex = 34;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimir.Location = new System.Drawing.Point(508, 6);
            this.btnimprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(92, 54);
            this.btnimprimir.TabIndex = 33;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // frmEmpleadoParaJubilacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 449);
            this.Controls.Add(this.dgvempleado);
            this.Controls.Add(this.btnimprimir);
            this.Name = "frmEmpleadoParaJubilacion";
            this.Text = "frmEmpleadoParaJubilacion";
            this.Load += new System.EventHandler(this.frmEmpleadoParaJubilacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvempleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvempleado;
        private System.Windows.Forms.Button btnimprimir;
    }
}