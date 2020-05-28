namespace Parcial02_001591619_JESA
{
    partial class uscAnadirProducto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.lblBusiName = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cmbNegocios, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblBusiName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAnadir, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txbItemName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblItemName, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(353, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbNegocios
            // 
            this.cmbNegocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNegocios.FormattingEnabled = true;
            this.cmbNegocios.Location = new System.Drawing.Point(182, 58);
            this.cmbNegocios.Name = "cmbNegocios";
            this.cmbNegocios.Size = new System.Drawing.Size(164, 21);
            this.cmbNegocios.TabIndex = 6;
            // 
            // lblBusiName
            // 
            this.lblBusiName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusiName.AutoSize = true;
            this.lblBusiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusiName.ForeColor = System.Drawing.Color.White;
            this.lblBusiName.Location = new System.Drawing.Point(22, 59);
            this.lblBusiName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBusiName.Name = "lblBusiName";
            this.lblBusiName.Size = new System.Drawing.Size(131, 20);
            this.lblBusiName.TabIndex = 7;
            this.lblBusiName.Text = "Nombre Negocio:";
            this.lblBusiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAnadir.BackColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.btnAnadir, 2);
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(100, 234);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(153, 37);
            this.btnAnadir.TabIndex = 15;
            this.btnAnadir.Text = "Añadir Producto";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // txbItemName
            // 
            this.txbItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbItemName.Location = new System.Drawing.Point(180, 151);
            this.txbItemName.Margin = new System.Windows.Forms.Padding(2);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.Size = new System.Drawing.Size(168, 20);
            this.txbItemName.TabIndex = 16;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(19, 151);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(137, 20);
            this.lblItemName.TabIndex = 17;
            this.lblItemName.Text = "Nombre Producto:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uscAnadirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "uscAnadirProducto";
            this.Size = new System.Drawing.Size(353, 326);
            this.Load += new System.EventHandler(this.uscAnadirProducto_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.Label lblBusiName;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.Label lblItemName;
    }
}
