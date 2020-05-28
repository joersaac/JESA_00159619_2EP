namespace Parcial02_001591619_JESA
{
    partial class uscEliminarNegocio
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
            this.tlpELiminarN = new System.Windows.Forms.TableLayoutPanel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblBusiName = new System.Windows.Forms.Label();
            this.cmbNegocios = new System.Windows.Forms.ComboBox();
            this.tlpELiminarN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpELiminarN
            // 
            this.tlpELiminarN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpELiminarN.ColumnCount = 2;
            this.tlpELiminarN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpELiminarN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpELiminarN.Controls.Add(this.lblBusiName, 0, 0);
            this.tlpELiminarN.Controls.Add(this.cmbNegocios, 1, 0);
            this.tlpELiminarN.Controls.Add(this.btnEliminar, 0, 1);
            this.tlpELiminarN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpELiminarN.Location = new System.Drawing.Point(0, 0);
            this.tlpELiminarN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpELiminarN.Name = "tlpELiminarN";
            this.tlpELiminarN.RowCount = 2;
            this.tlpELiminarN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpELiminarN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpELiminarN.Size = new System.Drawing.Size(618, 502);
            this.tlpELiminarN.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.SlateBlue;
            this.tlpELiminarN.SetColumnSpan(this.btnEliminar, 2);
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(194, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(230, 57);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar Negocio";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblBusiName
            // 
            this.lblBusiName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBusiName.AutoSize = true;
            this.lblBusiName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusiName.ForeColor = System.Drawing.Color.White;
            this.lblBusiName.Location = new System.Drawing.Point(52, 111);
            this.lblBusiName.Name = "lblBusiName";
            this.lblBusiName.Size = new System.Drawing.Size(205, 29);
            this.lblBusiName.TabIndex = 4;
            this.lblBusiName.Text = "Nombre Negocio:";
            this.lblBusiName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNegocios
            // 

            this.cmbNegocios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbNegocios.FormattingEnabled = true;
            this.cmbNegocios.Location = new System.Drawing.Point(341, 111);
            this.cmbNegocios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbNegocios.Name = "cmbNegocios";
            this.cmbNegocios.Size = new System.Drawing.Size(244, 28);
            this.cmbNegocios.TabIndex = 5;
            // 
            // uscEliminarNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tlpELiminarN);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uscEliminarNegocio";
            this.Size = new System.Drawing.Size(618, 502);
            this.Load += new System.EventHandler(this.uscEliminarNegocio_Load);
            this.tlpELiminarN.ResumeLayout(false);
            this.tlpELiminarN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpELiminarN;
        private System.Windows.Forms.Label lblBusiName;
        private System.Windows.Forms.ComboBox cmbNegocios;
        private System.Windows.Forms.Button btnEliminar;
    }
}
