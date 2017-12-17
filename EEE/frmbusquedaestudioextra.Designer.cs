namespace EEE
{
    partial class frmbusquedaestudioextra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmbusquedaestudioextra));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbtnestudiextra = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.dgvestudioextra = new System.Windows.Forms.DataGridView();
            this.bntBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudioextra)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(112, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(177, 20);
            this.txtBuscar.TabIndex = 24;
            // 
            // rbtnestudiextra
            // 
            this.rbtnestudiextra.AutoSize = true;
            this.rbtnestudiextra.Location = new System.Drawing.Point(55, 27);
            this.rbtnestudiextra.Name = "rbtnestudiextra";
            this.rbtnestudiextra.Size = new System.Drawing.Size(62, 17);
            this.rbtnestudiextra.TabIndex = 23;
            this.rbtnestudiextra.TabStop = true;
            this.rbtnestudiextra.Text = "Nombre";
            this.rbtnestudiextra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnestudiextra.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(15, 27);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(34, 17);
            this.rbtnId.TabIndex = 22;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Id";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // dgvestudioextra
            // 
            this.dgvestudioextra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvestudioextra.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvestudioextra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestudioextra.Location = new System.Drawing.Point(15, 89);
            this.dgvestudioextra.Name = "dgvestudioextra";
            this.dgvestudioextra.Size = new System.Drawing.Size(385, 174);
            this.dgvestudioextra.TabIndex = 21;
            this.dgvestudioextra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvestudioextra_CellContentClick);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(304, 8);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(95, 54);
            this.bntBuscar.TabIndex = 20;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // frmbusquedaestudioextra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(423, 273);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnestudiextra);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.dgvestudioextra);
            this.Controls.Add(this.bntBuscar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmbusquedaestudioextra";
            this.Text = "frmbusquedaestudioextra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudioextra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rbtnestudiextra;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.DataGridView dgvestudioextra;
        private System.Windows.Forms.Button bntBuscar;
    }
}