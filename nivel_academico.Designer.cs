namespace EEE
{
    partial class nivel_academico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nivel_academico));
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.lbnnivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnivel
            // 
            this.txtnivel.Location = new System.Drawing.Point(159, 79);
            this.txtnivel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(332, 22);
            this.txtnivel.TabIndex = 3;
            // 
            // lbnnivel
            // 
            this.lbnnivel.AutoSize = true;
            this.lbnnivel.Location = new System.Drawing.Point(28, 84);
            this.lbnnivel.Name = "lbnnivel";
            this.lbnnivel.Size = new System.Drawing.Size(112, 17);
            this.lbnnivel.TabIndex = 4;
            this.lbnnivel.Text = "Nivel Academico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(459, 18);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 17);
            this.lblusuario.TabIndex = 11;
            this.lblusuario.Text = "ADMIN";
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(368, 151);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(123, 48);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(239, 151);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(123, 48);
            this.btnguardar.TabIndex = 7;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncrear
            // 
            this.btncrear.Image = ((System.Drawing.Image)(resources.GetObject("btncrear.Image")));
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.Location = new System.Drawing.Point(121, 151);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(112, 48);
            this.btncrear.TabIndex = 6;
            this.btncrear.Text = "Crear";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // nivel_academico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources._42657hd;
            this.ClientSize = new System.Drawing.Size(523, 242);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.lbnnivel);
            this.Controls.Add(this.txtnivel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "nivel_academico";
            this.Text = "nivel_academico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbnnivel;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.TextBox txtnivel;
    }
}