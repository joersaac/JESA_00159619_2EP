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
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarD = new System.Windows.Forms.Button();
            this.uscAnadirDireccion1 = new Parcial02_001591619_JESA.uscAnadirDireccion();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpOrdenes = new System.Windows.Forms.TableLayoutPanel();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.btnEliminarO = new System.Windows.Forms.Button();
            this.btnRefrescarO = new System.Windows.Forms.Button();
            this.btnRealizarOrden = new System.Windows.Forms.Button();
            this.uscRealizarOrden1 = new Parcial02_001591619_JESA.uscRealizarOrden();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tlpDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDirecciones)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tlpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
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
            this.tlpDirecciones.Controls.Add(this.btnRefrescar, 0, 1);
            this.tlpDirecciones.Controls.Add(this.dgvDirecciones, 0, 0);
            this.tlpDirecciones.Controls.Add(this.btnAnadir, 1, 1);
            this.tlpDirecciones.Controls.Add(this.btnModificar, 2, 1);
            this.tlpDirecciones.Controls.Add(this.btnEliminarD, 3, 1);
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
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRefrescar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.ForeColor = System.Drawing.Color.White;
            this.btnRefrescar.Location = new System.Drawing.Point(3, 587);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(585, 59);
            this.btnRefrescar.TabIndex = 11;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
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
            this.dgvDirecciones.Size = new System.Drawing.Size(583, 574);
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
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(791, 587);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(191, 59);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarD
            // 
            this.btnEliminarD.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminarD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarD.ForeColor = System.Drawing.Color.White;
            this.btnEliminarD.Location = new System.Drawing.Point(988, 587);
            this.btnEliminarD.Name = "btnEliminarD";
            this.btnEliminarD.Size = new System.Drawing.Size(193, 59);
            this.btnEliminarD.TabIndex = 9;
            this.btnEliminarD.Text = "Eliminar";
            this.btnEliminarD.UseVisualStyleBackColor = false;
            this.btnEliminarD.Click += new System.EventHandler(this.btnEliminarD_Click);
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
            this.tabPage3.Controls.Add(this.tlpOrdenes);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1192, 659);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ordenes";
            // 
            // tlpOrdenes
            // 
            this.tlpOrdenes.ColumnCount = 3;
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOrdenes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpOrdenes.Controls.Add(this.dgvOrdenes, 0, 0);
            this.tlpOrdenes.Controls.Add(this.btnEliminarO, 2, 1);
            this.tlpOrdenes.Controls.Add(this.btnRefrescarO, 0, 1);
            this.tlpOrdenes.Controls.Add(this.btnRealizarOrden, 1, 1);
            this.tlpOrdenes.Controls.Add(this.uscRealizarOrden1, 1, 0);
            this.tlpOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOrdenes.Location = new System.Drawing.Point(0, 0);
            this.tlpOrdenes.Name = "tlpOrdenes";
            this.tlpOrdenes.RowCount = 2;
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpOrdenes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpOrdenes.Size = new System.Drawing.Size(1192, 659);
            this.tlpOrdenes.TabIndex = 0;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrdenes.Location = new System.Drawing.Point(4, 5);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.RowHeadersWidth = 62;
            this.dgvOrdenes.Size = new System.Drawing.Size(588, 583);
            this.dgvOrdenes.TabIndex = 1;
            // 
            // btnEliminarO
            // 
            this.btnEliminarO.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminarO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarO.ForeColor = System.Drawing.Color.White;
            this.btnEliminarO.Location = new System.Drawing.Point(897, 596);
            this.btnEliminarO.Name = "btnEliminarO";
            this.btnEliminarO.Size = new System.Drawing.Size(292, 60);
            this.btnEliminarO.TabIndex = 14;
            this.btnEliminarO.Text = "Eliminar";
            this.btnEliminarO.UseVisualStyleBackColor = false;
            this.btnEliminarO.Click += new System.EventHandler(this.btnEliminarO_Click);
            // 
            // btnRefrescarO
            // 
            this.btnRefrescarO.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRefrescarO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefrescarO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescarO.ForeColor = System.Drawing.Color.White;
            this.btnRefrescarO.Location = new System.Drawing.Point(3, 596);
            this.btnRefrescarO.Name = "btnRefrescarO";
            this.btnRefrescarO.Size = new System.Drawing.Size(590, 60);
            this.btnRefrescarO.TabIndex = 12;
            this.btnRefrescarO.Text = "Refrescar";
            this.btnRefrescarO.UseVisualStyleBackColor = false;
            this.btnRefrescarO.Click += new System.EventHandler(this.btnRefrescarO_Click);
            // 
            // btnRealizarOrden
            // 
            this.btnRealizarOrden.BackColor = System.Drawing.Color.SlateBlue;
            this.btnRealizarOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRealizarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarOrden.ForeColor = System.Drawing.Color.White;
            this.btnRealizarOrden.Location = new System.Drawing.Point(599, 596);
            this.btnRealizarOrden.Name = "btnRealizarOrden";
            this.btnRealizarOrden.Size = new System.Drawing.Size(292, 60);
            this.btnRealizarOrden.TabIndex = 13;
            this.btnRealizarOrden.Text = "Realizar orden";
            this.btnRealizarOrden.UseVisualStyleBackColor = false;
            this.btnRealizarOrden.Click += new System.EventHandler(this.btnRealizarOrden_Click);
            // 
            // uscRealizarOrden1
            // 
            this.uscRealizarOrden1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tlpOrdenes.SetColumnSpan(this.uscRealizarOrden1, 2);
            this.uscRealizarOrden1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscRealizarOrden1.Location = new System.Drawing.Point(599, 3);
            this.uscRealizarOrden1.Name = "uscRealizarOrden1";
            this.uscRealizarOrden1.Size = new System.Drawing.Size(590, 587);
            this.uscRealizarOrden1.TabIndex = 15;
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
            this.tabPage3.ResumeLayout(false);
            this.tlpOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
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
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarD;
        private uscAnadirDireccion uscAnadirDireccion1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.TableLayoutPanel tlpOrdenes;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.Button btnEliminarO;
        private System.Windows.Forms.Button btnRefrescarO;
        private System.Windows.Forms.Button btnRealizarOrden;
        private uscRealizarOrden uscRealizarOrden1;
    }
}