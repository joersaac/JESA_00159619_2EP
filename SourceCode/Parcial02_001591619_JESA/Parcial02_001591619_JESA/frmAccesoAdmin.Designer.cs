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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tloMantenimientoU = new System.Windows.Forms.TableLayoutPanel();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.tabAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tloMantenimientoU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
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
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(857, 500);
            this.tabAdmin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage1.Controls.Add(this.picLogo);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage2.Controls.Add(this.tloMantenimientoU);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento usuario";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(849, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento negocios";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(849, 467);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Mantenimiento productos";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(849, 467);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Historial ordenes";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(292, 78);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(268, 256);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // tloMantenimientoU
            // 
            this.tloMantenimientoU.ColumnCount = 3;
            this.tloMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tloMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloMantenimientoU.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tloMantenimientoU.Controls.Add(this.dgvUsuario, 0, 0);
            this.tloMantenimientoU.Controls.Add(this.btnCrearU, 1, 1);
            this.tloMantenimientoU.Controls.Add(this.btnEliminarU, 2, 1);
            this.tloMantenimientoU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tloMantenimientoU.Location = new System.Drawing.Point(3, 3);
            this.tloMantenimientoU.Name = "tloMantenimientoU";
            this.tloMantenimientoU.RowCount = 2;
            this.tloMantenimientoU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tloMantenimientoU.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tloMantenimientoU.Size = new System.Drawing.Size(843, 461);
            this.tloMantenimientoU.TabIndex = 0;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuario.Location = new System.Drawing.Point(3, 3);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersWidth = 62;
            this.tloMantenimientoU.SetRowSpan(this.dgvUsuario, 2);
            this.dgvUsuario.RowTemplate.Height = 28;
            this.dgvUsuario.Size = new System.Drawing.Size(415, 455);
            this.dgvUsuario.TabIndex = 0;
            // 
            // btnCrearU
            // 
            this.btnCrearU.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCrearU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearU.ForeColor = System.Drawing.Color.White;
            this.btnCrearU.Location = new System.Drawing.Point(424, 417);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(204, 41);
            this.btnCrearU.TabIndex = 6;
            this.btnCrearU.Text = "Crear";
            this.btnCrearU.UseVisualStyleBackColor = false;
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.BackColor = System.Drawing.Color.SlateBlue;
            this.btnEliminarU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminarU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarU.ForeColor = System.Drawing.Color.White;
            this.btnEliminarU.Location = new System.Drawing.Point(634, 417);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(206, 41);
            this.btnEliminarU.TabIndex = 7;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = false;
            // 
            // frmAccesoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 500);
            this.Controls.Add(this.tabAdmin);
            this.Name = "frmAccesoAdmin";
            this.Text = "frmAccesoAdmin";
            this.tabAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tloMantenimientoU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tloMantenimientoU;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.Button btnCrearU;
        private System.Windows.Forms.Button btnEliminarU;
    }
}