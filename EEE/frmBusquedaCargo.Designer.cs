namespace EEE
{
    partial class frmBusquedaCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusquedaCargo));
            this.dgvcargo = new System.Windows.Forms.DataGridView();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.rbtnestudi = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.bntBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvcargo
            // 
            this.dgvcargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvcargo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcargo.Location = new System.Drawing.Point(27, 92);
            this.dgvcargo.Name = "dgvcargo";
            this.dgvcargo.Size = new System.Drawing.Size(370, 174);
            this.dgvcargo.TabIndex = 16;
            this.dgvcargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargo_CellContentClick);
            this.dgvcargo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargo_CellDoubleClick);
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(12, 30);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(34, 17);
            this.rbtnId.TabIndex = 17;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Id";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // rbtnestudi
            // 
            this.rbtnestudi.AutoSize = true;
            this.rbtnestudi.Location = new System.Drawing.Point(52, 30);
            this.rbtnestudi.Name = "rbtnestudi";
            this.rbtnestudi.Size = new System.Drawing.Size(53, 17);
            this.rbtnestudi.TabIndex = 18;
            this.rbtnestudi.TabStop = true;
            this.rbtnestudi.Text = "Cargo";
            this.rbtnestudi.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(111, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 20);
            this.txtBuscar.TabIndex = 19;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(303, 11);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(94, 54);
            this.bntBuscar.TabIndex = 15;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // frmBusquedaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(417, 319);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnestudi);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.dgvcargo);
            this.Controls.Add(this.bntBuscar);
            this.Name = "frmBusquedaCargo";
            this.Text = "frmBusquedaCargo";
            this.Load += new System.EventHandler(this.frmBusquedaCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBuscar;
        private System.Windows.Forms.DataGridView dgvcargo;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.RadioButton rbtnestudi;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}