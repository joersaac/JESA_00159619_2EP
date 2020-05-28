namespace Parcial02_001591619_JESA
{
    partial class frmAccesoNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoNormal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpDirecciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.uscAnadirDireccion1 = new Parcial02_001591619_JESA.uscAnadirDireccion();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 692);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.picLogo);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1192, 659);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(486, 183);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(268, 255);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.tlpDirecciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1192, 659);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Direcciones";
            // 
            // tlpDirecciones
            // 
            this.tlpDirecciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpDirecciones.ColumnCount = 4;
            this.tlpDirecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.995F));
            this.tlpDirecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tlpDirecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tlpDirecciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66833F));
            this.tlpDirecciones.Controls.Add(this.dgvDirecciones, 0, 0);
            this.tlpDirecciones.Controls.Add(this.btnAnadir, 1, 1);
            this.tlpDirecciones.Controls.Add(this.button1, 2, 1);
            this.tlpDirecciones.Controls.Add(this.button2, 3, 1);
            this.tlpDirecciones.Controls.Add(this.uscAnadirDireccion1, 1, 0);
            this.tlpDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDirecciones.Location = new System.Drawing.Point(4, 5);
            this.tlpDirecciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpDirecciones.Name = "tlpDirecciones";
            this.tlpDirecciones.RowCount = 2;
            this.tlpDirecciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpDirecciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDirecciones.Size = new System.Drawing.Size(1184, 649);
            this.tlpDirecciones.TabIndex = 0;
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvDirecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDirecciones.Location = new System.Drawing.Point(4, 5);
            this.dgvDirecciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDirecciones.Name = "dgvDirecciones";
            this.dgvDirecciones.RowHeadersWidth = 62;
            this.tlpDirecciones.SetRowSpan(this.dgvDirecciones, 2);
            this.dgvDirecciones.Size = new System.Drawing.Size(583, 639);
            this.dgvDirecciones.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAnadir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(594, 587);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(191, 59);
            this.btnAnadir.TabIndex = 7;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(791, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 59);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(988, 587);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 59);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // uscAnadirDireccion1
            // 
            this.uscAnadirDireccion1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tlpDirecciones.SetColumnSpan(this.uscAnadirDireccion1, 3);
            this.uscAnadirDireccion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAnadirDireccion1.Location = new System.Drawing.Point(595, 5);
            this.uscAnadirDireccion1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uscAnadirDireccion1.Name = "uscAnadirDireccion1";
            this.uscAnadirDireccion1.Size = new System.Drawing.Size(585, 574);
            this.uscAnadirDireccion1.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1192, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ordenes";
            // 
            // frmAccesoNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAccesoNormal";
            this.Text = "frmAccesoNormal";
            this.Load += new System.EventHandler(this.frmAccesoNormal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tlpDirecciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tlpDirecciones;
        private System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private uscAnadirDireccion uscAnadirDireccion1;
    }
}