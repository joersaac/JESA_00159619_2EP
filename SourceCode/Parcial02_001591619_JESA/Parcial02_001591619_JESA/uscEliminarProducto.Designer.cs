namespace Parcial02_001591619_JESA
{
    partial class uscEliminarProducto
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
            this.tlpEliminarProducto = new System.Windows.Forms.TableLayoutPanel();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tlpEliminarProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEliminarProducto
            // 
            this.tlpEliminarProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpEliminarProducto.ColumnCount = 2;
            this.tlpEliminarProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarProducto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarProducto.Controls.Add(this.btnEliminar, 0, 1);
            this.tlpEliminarProducto.Controls.Add(this.cmbProductos, 1, 0);
            this.tlpEliminarProducto.Controls.Add(this.lblItemName, 0, 0);
            this.tlpEliminarProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEliminarProducto.Location = new System.Drawing.Point(0, 0);
            this.tlpEliminarProducto.Name = "tlpEliminarProducto";
            this.tlpEliminarProducto.RowCount = 2;
            this.tlpEliminarProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarProducto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarProducto.Size = new System.Drawing.Size(348, 313);
            this.tlpEliminarProducto.TabIndex = 0;
            // 
            // cmbProductos
            // 
            this.cmbProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(179, 67);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(164, 21);
            this.cmbProductos.TabIndex = 6;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(18, 68);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(137, 20);
            this.lblItemName.TabIndex = 7;
            this.lblItemName.Text = "Nombre Producto:";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.SlateBlue;
            this.tlpEliminarProducto.SetColumnSpan(this.btnEliminar, 2);
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(97, 216);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(153, 37);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // uscEliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tlpEliminarProducto);
            this.Name = "uscEliminarProducto";
            this.Size = new System.Drawing.Size(348, 313);
            this.Load += new System.EventHandler(this.uscEliminarProducto_Load);
            this.tlpEliminarProducto.ResumeLayout(false);
            this.tlpEliminarProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEliminarProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Button btnEliminar;
    }
}
