namespace Parcial02_001591619_JESA
{
    partial class frmCambioContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambioContra));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenaActual = new System.Windows.Forms.Label();
            this.lblContrasenaNueva = new System.Windows.Forms.Label();
            this.lblRepetirContra = new System.Windows.Forms.Label();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.txbContrasenaActual = new System.Windows.Forms.TextBox();
            this.txbContrasenaNew = new System.Windows.Forms.TextBox();
            this.txbRepetirContra = new System.Windows.Forms.TextBox();
            this.btnCC = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(49, 71);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(249, 240);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(342, 71);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(102, 29);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrasenaActual
            // 
            this.lblContrasenaActual.AutoSize = true;
            this.lblContrasenaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaActual.ForeColor = System.Drawing.Color.White;
            this.lblContrasenaActual.Location = new System.Drawing.Point(342, 144);
            this.lblContrasenaActual.Name = "lblContrasenaActual";
            this.lblContrasenaActual.Size = new System.Drawing.Size(211, 29);
            this.lblContrasenaActual.TabIndex = 3;
            this.lblContrasenaActual.Text = "Contraseña actual:";
            this.lblContrasenaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrasenaNueva
            // 
            this.lblContrasenaNueva.AutoSize = true;
            this.lblContrasenaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenaNueva.ForeColor = System.Drawing.Color.White;
            this.lblContrasenaNueva.Location = new System.Drawing.Point(342, 219);
            this.lblContrasenaNueva.Name = "lblContrasenaNueva";
            this.lblContrasenaNueva.Size = new System.Drawing.Size(212, 29);
            this.lblContrasenaNueva.TabIndex = 4;
            this.lblContrasenaNueva.Text = "Contraseña nueva:";
            this.lblContrasenaNueva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRepetirContra
            // 
            this.lblRepetirContra.AutoSize = true;
            this.lblRepetirContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetirContra.ForeColor = System.Drawing.Color.White;
            this.lblRepetirContra.Location = new System.Drawing.Point(342, 282);
            this.lblRepetirContra.Name = "lblRepetirContra";
            this.lblRepetirContra.Size = new System.Drawing.Size(222, 29);
            this.lblRepetirContra.TabIndex = 5;
            this.lblRepetirContra.Text = "Repetir contraseña:";
            this.lblRepetirContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(584, 75);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(231, 28);
            this.cmbUsuario.TabIndex = 6;
            // 
            // txbContrasenaActual
            // 
            this.txbContrasenaActual.Location = new System.Drawing.Point(584, 148);
            this.txbContrasenaActual.Name = "txbContrasenaActual";
            this.txbContrasenaActual.Size = new System.Drawing.Size(231, 26);
            this.txbContrasenaActual.TabIndex = 7;
            // 
            // txbContrasenaNew
            // 
            this.txbContrasenaNew.Location = new System.Drawing.Point(584, 223);
            this.txbContrasenaNew.Name = "txbContrasenaNew";
            this.txbContrasenaNew.Size = new System.Drawing.Size(231, 26);
            this.txbContrasenaNew.TabIndex = 8;
            // 
            // txbRepetirContra
            // 
            this.txbRepetirContra.Location = new System.Drawing.Point(584, 286);
            this.txbRepetirContra.Name = "txbRepetirContra";
            this.txbRepetirContra.Size = new System.Drawing.Size(231, 26);
            this.txbRepetirContra.TabIndex = 9;
            // 
            // btnCC
            // 
            this.btnCC.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCC.ForeColor = System.Drawing.Color.White;
            this.btnCC.Location = new System.Drawing.Point(286, 361);
            this.btnCC.Name = "btnCC";
            this.btnCC.Size = new System.Drawing.Size(257, 61);
            this.btnCC.TabIndex = 10;
            this.btnCC.Text = "Cambiar contraseña";
            this.btnCC.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(570, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(257, 61);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmCambioContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(839, 474);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCC);
            this.Controls.Add(this.txbRepetirContra);
            this.Controls.Add(this.txbContrasenaNew);
            this.Controls.Add(this.txbContrasenaActual);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblRepetirContra);
            this.Controls.Add(this.lblContrasenaNueva);
            this.Controls.Add(this.lblContrasenaActual);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.picLogo);
            this.Name = "frmCambioContra";
            this.Text = "Cambio contraseña";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenaActual;
        private System.Windows.Forms.Label lblContrasenaNueva;
        private System.Windows.Forms.Label lblRepetirContra;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TextBox txbContrasenaActual;
        private System.Windows.Forms.TextBox txbContrasenaNew;
        private System.Windows.Forms.TextBox txbRepetirContra;
        private System.Windows.Forms.Button btnCC;
        private System.Windows.Forms.Button btnCancelar;
    }
}