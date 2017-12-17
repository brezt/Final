namespace EEE
{
    partial class Login
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
            this.gruusuario = new System.Windows.Forms.GroupBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lbncontra = new System.Windows.Forms.Label();
            this.lbnusuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gruusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gruusuario
            // 
            this.gruusuario.BackgroundImage = global::EEE.Properties.Resources.html_page_background_color_website_web_within;
            this.gruusuario.Controls.Add(this.txtcontrasena);
            this.gruusuario.Controls.Add(this.txtusuario);
            this.gruusuario.Controls.Add(this.lbncontra);
            this.gruusuario.Controls.Add(this.lbnusuario);
            this.gruusuario.Controls.Add(this.pictureBox2);
            this.gruusuario.Location = new System.Drawing.Point(12, 339);
            this.gruusuario.Name = "gruusuario";
            this.gruusuario.Size = new System.Drawing.Size(848, 231);
            this.gruusuario.TabIndex = 1;
            this.gruusuario.TabStop = false;
            this.gruusuario.Text = "Usuario";
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(523, 135);
            this.txtcontrasena.Multiline = true;
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(228, 35);
            this.txtcontrasena.TabIndex = 4;
            this.txtcontrasena.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(523, 72);
            this.txtusuario.Multiline = true;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(228, 36);
            this.txtusuario.TabIndex = 3;
            // 
            // lbncontra
            // 
            this.lbncontra.AutoSize = true;
            this.lbncontra.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbncontra.Location = new System.Drawing.Point(377, 146);
            this.lbncontra.Name = "lbncontra";
            this.lbncontra.Size = new System.Drawing.Size(134, 24);
            this.lbncontra.TabIndex = 2;
            this.lbncontra.Text = "CONTRASEÑA";
            // 
            // lbnusuario
            // 
            this.lbnusuario.AutoSize = true;
            this.lbnusuario.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnusuario.Location = new System.Drawing.Point(415, 77);
            this.lbnusuario.Name = "lbnusuario";
            this.lbnusuario.Size = new System.Drawing.Size(96, 24);
            this.lbnusuario.TabIndex = 1;
            this.lbnusuario.Text = "USUARIO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::EEE.Properties.Resources.html_page_background_color_website_web_within;
            this.pictureBox2.Image = global::EEE.Properties.Resources.login_icon_png_27;
            this.pictureBox2.Location = new System.Drawing.Point(17, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EEE.Properties.Resources._44460_625470184135716_731242211_n;
            this.pictureBox1.Location = new System.Drawing.Point(303, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("News706 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(297, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 34);
            this.label3.TabIndex = 25;
            this.label3.Text = "ACCESO USUARIO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EEE.Properties.Resources.html_page_background_color_website_web_within;
            this.ClientSize = new System.Drawing.Size(900, 598);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gruusuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.gruusuario.ResumeLayout(false);
            this.gruusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gruusuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lbncontra;
        private System.Windows.Forms.Label lbnusuario;
        private System.Windows.Forms.Label label3;
    }
}