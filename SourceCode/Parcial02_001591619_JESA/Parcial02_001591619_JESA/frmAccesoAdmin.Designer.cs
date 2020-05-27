namespace Parcial02_001591619_JESA
{
    partial class frmAccesoAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccesoAdmin));
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tlpMantenimientoU = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.uscCrearUsuario1 = new Parcial02_001591619_JESA.uscCrearUsuario();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpMantenimientoN = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnadirN = new System.Windows.Forms.Button();
            this.uscAnadirNegocio1 = new Parcial02_001591619_JESA.uscAnadirNegocio();
            this.btnEliminarN = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tlpMantenimientoP = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.uscAnadirProducto1 = new Parcial02_001591619_JESA.uscAnadirProducto();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpMantenimientoU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tlpMantenimientoN.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tlpMantenimientoP.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tabPage1);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Controls.Add(this.tabPage3);
            this.tabAdmin.Controls.Add(this.tabPage4);
            this.tabAdmin.Controls.Add(this.tabPage5);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(765, 348);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.picLogo);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(757, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(285, 73);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(179, 166);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.tlpMantenimientoU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(757, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento usuario";
            // 
            // tlpMantenimientoU
            // 
            this.tlpMantenimientoU.ColumnCount = 3;
            this.tlpMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMantenimientoU.Controls.Add(this.btnRefrescar, 0, 1);
            this.tlpMantenimientoU.Controls.Add(this.dgvUsuario, 0, 0);
            this.tlpMantenimientoU.Controls.Add(this.btnCrearU, 1, 1);
            this.tlpMantenimientoU.Controls.Add(this.btnEliminarU, 2, 1);
            this.tlpMantenimientoU.Controls.Add(this.uscCrearUsuario1, 1, 0);
            this.tlpMantenimientoU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMantenimientoU.Location = new System.Drawing.Point(2, 2);
            this.tlpMantenimientoU.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMantenimientoU.Name = "tlpMantenimientoU";
            this.tlpMantenimientoU.RowCount = 2;
            this.tlpMantenimientoU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMantenimientoU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMantenimientoU.Size = new System.Drawing.Size(753, 318);
            this.tlpMantenimientoU.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefrescar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(131, 288);
            this.btnRefrescar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(113, 28);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuario.Location = new System.Drawing.Point(2, 2);
            this.dgvUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 62;
            this.dgvUsuario.RowTemplate.Height = 28;
            this.dgvUsuario.Size = new System.Drawing.Size(372, 282);
            this.dgvUsuario.TabIndex = 0;
            // 
            // btnCrearU
            // 
            this.btnCrearU.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCrearU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearU.ForeColor = System.Drawing.Color.White;
            this.btnCrearU.Location = new System.Drawing.Point(378, 288);
            this.btnCrearU.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(184, 28);
            this.btnCrearU.TabIndex = 6;
            this.btnCrearU.Text = "Crear";
            this.btnCrearU.UseVisualStyleBackColor = false;
            this.btnCrearU.Click += new System.EventHandler(this.btnCrearU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminarU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarU.ForeColor = System.Drawing.Color.White;
            this.btnEliminarU.Location = new System.Drawing.Point(566, 288);
            this.btnEliminarU.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(185, 28);
            this.btnEliminarU.TabIndex = 7;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = false;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // uscCrearUsuario1
            // 
            this.uscCrearUsuario1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tlpMantenimientoU.SetColumnSpan(this.uscCrearUsuario1, 2);
            this.uscCrearUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCrearUsuario1.Location = new System.Drawing.Point(377, 1);
            this.uscCrearUsuario1.Margin = new System.Windows.Forms.Padding(1);
            this.uscCrearUsuario1.Name = "uscCrearUsuario1";
            this.uscCrearUsuario1.Size = new System.Drawing.Size(375, 284);
            this.uscCrearUsuario1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage3.Controls.Add(this.tlpMantenimientoN);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(757, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento negocios";
            // 
            // tlpMantenimientoN
            // 
            this.tlpMantenimientoN.ColumnCount = 2;
            this.tlpMantenimientoN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMantenimientoN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMantenimientoN.Controls.Add(this.btnAnadirN, 0, 1);
            this.tlpMantenimientoN.Controls.Add(this.uscAnadirNegocio1, 0, 0);
            this.tlpMantenimientoN.Controls.Add(this.btnEliminarN, 1, 1);
            this.tlpMantenimientoN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMantenimientoN.Location = new System.Drawing.Point(0, 0);
            this.tlpMantenimientoN.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMantenimientoN.Name = "tlpMantenimientoN";
            this.tlpMantenimientoN.RowCount = 2;
            this.tlpMantenimientoN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMantenimientoN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMantenimientoN.Size = new System.Drawing.Size(757, 322);
            this.tlpMantenimientoN.TabIndex = 0;
            // 
            // btnAnadirN
            // 
            this.btnAnadirN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnadirN.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAnadirN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirN.ForeColor = System.Drawing.Color.White;
            this.btnAnadirN.Location = new System.Drawing.Point(116, 291);
            this.btnAnadirN.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadirN.Name = "btnAnadirN";
            this.btnAnadirN.Size = new System.Drawing.Size(146, 29);
            this.btnAnadirN.TabIndex = 10;
            this.btnAnadirN.Text = "Añadir";
            this.btnAnadirN.UseVisualStyleBackColor = false;
            this.btnAnadirN.Click += new System.EventHandler(this.btnAnadirN_Click);
            // 
            // uscAnadirNegocio1
            // 
            this.uscAnadirNegocio1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tlpMantenimientoN.SetColumnSpan(this.uscAnadirNegocio1, 2);
            this.uscAnadirNegocio1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAnadirNegocio1.Location = new System.Drawing.Point(2, 2);
            this.uscAnadirNegocio1.Margin = new System.Windows.Forms.Padding(2);
            this.uscAnadirNegocio1.Name = "uscAnadirNegocio1";
            this.uscAnadirNegocio1.Size = new System.Drawing.Size(753, 285);
            this.uscAnadirNegocio1.TabIndex = 9;
            // 
            // btnEliminarN
            // 
            this.btnEliminarN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarN.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminarN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarN.ForeColor = System.Drawing.Color.White;
            this.btnEliminarN.Location = new System.Drawing.Point(510, 291);
            this.btnEliminarN.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarN.Name = "btnEliminarN";
            this.btnEliminarN.Size = new System.Drawing.Size(115, 29);
            this.btnEliminarN.TabIndex = 8;
            this.btnEliminarN.Text = "Eliminar";
            this.btnEliminarN.UseVisualStyleBackColor = false;
            this.btnEliminarN.Click += new System.EventHandler(this.btnEliminarN_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage4.Controls.Add(this.tlpMantenimientoP);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(757, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mantenimiento productos";
            // 
            // tlpMantenimientoP
            // 
            this.tlpMantenimientoP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMantenimientoP.ColumnCount = 2;
            this.tlpMantenimientoP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMantenimientoP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMantenimientoP.Controls.Add(this.btnAnadir, 0, 1);
            this.tlpMantenimientoP.Controls.Add(this.uscAnadirProducto1, 0, 0);
            this.tlpMantenimientoP.Controls.Add(this.btnEliminar, 1, 1);
            this.tlpMantenimientoP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMantenimientoP.Location = new System.Drawing.Point(0, 0);
            this.tlpMantenimientoP.Name = "tlpMantenimientoP";
            this.tlpMantenimientoP.RowCount = 2;
            this.tlpMantenimientoP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMantenimientoP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMantenimientoP.Size = new System.Drawing.Size(757, 322);
            this.tlpMantenimientoP.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnadir.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(116, 291);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(146, 29);
            this.btnAnadir.TabIndex = 14;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // uscAnadirProducto1
            // 
            this.uscAnadirProducto1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uscAnadirProducto1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tlpMantenimientoP.SetColumnSpan(this.uscAnadirProducto1, 2);
            this.uscAnadirProducto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscAnadirProducto1.Location = new System.Drawing.Point(3, 3);
            this.uscAnadirProducto1.Name = "uscAnadirProducto1";
            this.uscAnadirProducto1.Size = new System.Drawing.Size(751, 283);
            this.uscAnadirProducto1.TabIndex = 13;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(510, 291);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 29);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(757, 322);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historial ordenes";
            // 
            // frmAccesoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 348);
            this.Controls.Add(this.tabAdmin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAccesoAdmin";
            this.Text = "frmAccesoAdmin";
            this.Load += new System.EventHandler(this.frmAccesoAdmin_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tlpMantenimientoU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tlpMantenimientoN.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tlpMantenimientoP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TableLayoutPanel tlpMantenimientoU;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnCrearU;
        private System.Windows.Forms.Button btnEliminarU;
        private uscCrearUsuario uscCrearUsuario1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TableLayoutPanel tlpMantenimientoN;
        private System.Windows.Forms.Button btnEliminarN;
        private uscAnadirNegocio uscAnadirNegocio1;
        private System.Windows.Forms.Button btnAnadirN;
        private System.Windows.Forms.TableLayoutPanel tlpMantenimientoP;
        private System.Windows.Forms.Button btnEliminar;
        private uscAnadirProducto uscAnadirProducto1;
        private System.Windows.Forms.Button btnAnadir;
    }
}