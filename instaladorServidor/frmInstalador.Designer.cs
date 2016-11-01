namespace instaladorServidor
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtServerIp = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.txtHWK = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(237, 133);
            this.txtEmpresa.Multiline = true;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(211, 49);
            this.txtEmpresa.TabIndex = 1;
            // 
            // txtServerIp
            // 
            this.txtServerIp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtServerIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerIp.Enabled = false;
            this.txtServerIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerIp.Location = new System.Drawing.Point(237, 100);
            this.txtServerIp.Name = "txtServerIp";
            this.txtServerIp.Size = new System.Drawing.Size(211, 19);
            this.txtServerIp.TabIndex = 5;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(237, 219);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(211, 17);
            this.txtMail.TabIndex = 7;
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.AutoEllipsis = true;
            this.btnSolicitar.BackgroundImage = global::instaladorServidor.Properties.Resources.password_icono_200x200;
            this.btnSolicitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolicitar.Location = new System.Drawing.Point(249, 252);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(62, 55);
            this.btnSolicitar.TabIndex = 8;
            this.btnSolicitar.UseVisualStyleBackColor = true;
            this.btnSolicitar.Click += new System.EventHandler(this.btnSolicitar_Click);
            // 
            // txtHWK
            // 
            this.txtHWK.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtHWK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHWK.Location = new System.Drawing.Point(82, 317);
            this.txtHWK.Multiline = true;
            this.txtHWK.Name = "txtHWK";
            this.txtHWK.Size = new System.Drawing.Size(374, 47);
            this.txtHWK.TabIndex = 10;
            this.txtHWK.Click += new System.EventHandler(this.txtHWK_Click);
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.BackgroundImage = global::instaladorServidor.Properties.Resources.boton_LiberacionLicencia;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(353, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 55);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.BackgroundImage = global::instaladorServidor.Properties.Resources.cerrar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(411, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 33);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::instaladorServidor.Properties.Resources.INSTALACION_SERVER_2;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHWK);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtServerIp);
            this.Controls.Add(this.txtEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalador Vertical Server v1.0.0.0";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtServerIp;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.TextBox txtHWK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

