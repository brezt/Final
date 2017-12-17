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
            this.txtBuscar.Location = new System.Drawing.Point(150, 33);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(235, 22);
            this.txtBuscar.TabIndex = 24;
            // 
            // rbtnestudiextra
            // 
            this.rbtnestudiextra.AutoSize = true;
            this.rbtnestudiextra.Location = new System.Drawing.Point(73, 33);
            this.rbtnestudiextra.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnestudiextra.Name = "rbtnestudiextra";
            this.rbtnestudiextra.Size = new System.Drawing.Size(79, 21);
            this.rbtnestudiextra.TabIndex = 23;
            this.rbtnestudiextra.TabStop = true;
            this.rbtnestudiextra.Text = "Nombre";
            this.rbtnestudiextra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnestudiextra.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Location = new System.Drawing.Point(20, 33);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(40, 21);
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
            this.dgvestudioextra.Location = new System.Drawing.Point(20, 109);
            this.dgvestudioextra.Margin = new System.Windows.Forms.Padding(4);
            this.dgvestudioextra.Name = "dgvestudioextra";
            this.dgvestudioextra.Size = new System.Drawing.Size(513, 214);
            this.dgvestudioextra.TabIndex = 21;
            // 
            // bntBuscar
            // 
            this.bntBuscar.Image = ((System.Drawing.Image)(resources.GetObject("bntBuscar.Image")));
            this.bntBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntBuscar.Location = new System.Drawing.Point(406, 10);
            this.bntBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bntBuscar.Name = "bntBuscar";
            this.bntBuscar.Size = new System.Drawing.Size(127, 66);
            this.bntBuscar.TabIndex = 20;
            this.bntBuscar.Text = "Buscar";
            this.bntBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntBuscar.UseVisualStyleBackColor = true;
            this.bntBuscar.Click += new System.EventHandler(this.bntBuscar_Click);
            // 
            // frmbusquedaestudioextra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(564, 336);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rbtnestudiextra);
            this.Controls.Add(this.rbtnId);
            this.Controls.Add(this.dgvestudioextra);
            this.Controls.Add(this.bntBuscar);
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