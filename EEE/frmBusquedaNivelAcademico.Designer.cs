﻿namespace EEE
{
    partial class frmBusquedaNivelAcademico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaNivelAcademico));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnNivel = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.dgvnivelacad = new System.Windows.Forms.DataGridView();
            this.bntBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnivelacad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(122, 41);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 20);
            this.txtBuscar.TabIndex = 24;
            // 
            // rbtnNivel
            // 
            this.rbtnNivel.AutoSize = true;
            this.rbtnNivel.Location = new System.Drawing.Point(63, 41);
            this.rbtnNivel.Name = "rbtnNivel";
            this.rbtnNivel.Size = new System.Drawing.Size(49, 17);
            this.rbtnNivel.TabIndex = 23;
            this.rbtnNivel.TabStop = true;
            this.rbtnNivel.Text = "Nivel";
            this.rbtnNivel.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(23, 41);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(34, 17);
            this.rbtnId.TabIndex = 22;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Id";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // dgvnivelacad
            // 
            this.dgvnivelacad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnivelacad.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvnivelacad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnivelacad.Location = new System.Drawing.Point(23, 103);
            this.dgvnivelacad.Name = "dgvnivelacad";
            this.dgvnivelacad.Size = new System.Drawing.Size(385, 174);
            this.dgvnivelacad.TabIndex = 21;
            this.dgvnivelacad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(314, 22);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(94, 54);
            this.bntBuscar.TabIndex = 20;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // frmBusquedaNivelAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(423, 304);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnNivel);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.dgvnivelacad);
            this.Controls.Add(this.bntBuscar);
            this.Name = "frmBusquedaNivelAcademico";
            this.Text = "frmBusquedaNivelAcademico";
            this.Load += new System.EventHandler(this.frmBusquedaNivelAcademico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnivelacad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnNivel;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.DataGridView dgvnivelacad;
        private System.Windows.Forms.Button bntBuscar;
        public System.Windows.Forms.TextBox txtBuscar;
    }
}