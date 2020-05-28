namespace Parcial02_001591619_JESA
{
    partial class uscEliminarPedido
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
            this.tlpEliminarPedido = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrden = new System.Windows.Forms.Label();
            this.cmbOrdenes = new System.Windows.Forms.ComboBox();
            this.btnRealizarOrden = new System.Windows.Forms.Button();
            this.tlpEliminarPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEliminarPedido
            // 
            this.tlpEliminarPedido.ColumnCount = 2;
            this.tlpEliminarPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarPedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarPedido.Controls.Add(this.btnRealizarOrden, 0, 1);
            this.tlpEliminarPedido.Controls.Add(this.cmbOrdenes, 1, 0);
            this.tlpEliminarPedido.Controls.Add(this.lblOrden, 0, 0);
            this.tlpEliminarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEliminarPedido.Location = new System.Drawing.Point(0, 0);
            this.tlpEliminarPedido.Name = "tlpEliminarPedido";
            this.tlpEliminarPedido.RowCount = 2;
            this.tlpEliminarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarPedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEliminarPedido.Size = new System.Drawing.Size(568, 467);
            this.tlpEliminarPedido.TabIndex = 0;
            // 
            // lblOrden
            // 
            this.lblOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrden.AutoSize = true;
            this.lblOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrden.ForeColor = System.Drawing.Color.White;
            this.lblOrden.Location = new System.Drawing.Point(85, 102);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(113, 29);
            this.lblOrden.TabIndex = 17;
            this.lblOrden.Text = "Ordenes:";
            this.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOrdenes
            // 
            this.cmbOrdenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrdenes.FormattingEnabled = true;
            this.cmbOrdenes.Location = new System.Drawing.Point(287, 102);
            this.cmbOrdenes.Name = "cmbOrdenes";
            this.cmbOrdenes.Size = new System.Drawing.Size(278, 28);
            this.cmbOrdenes.TabIndex = 18;
            // 
            // btnRealizarOrden
            // 
            this.btnRealizarOrden.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRealizarOrden.BackColor = System.Drawing.Color.SlateBlue;
            this.tlpEliminarPedido.SetColumnSpan(this.btnRealizarOrden, 2);
            this.btnRealizarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarOrden.ForeColor = System.Drawing.Color.White;
            this.btnRealizarOrden.Location = new System.Drawing.Point(138, 320);
            this.btnRealizarOrden.Name = "btnRealizarOrden";
            this.btnRealizarOrden.Size = new System.Drawing.Size(292, 60);
            this.btnRealizarOrden.TabIndex = 19;
            this.btnRealizarOrden.Text = "Realizar orden";
            this.btnRealizarOrden.UseVisualStyleBackColor = false;
            this.btnRealizarOrden.Click += new System.EventHandler(this.btnRealizarOrden_Click);
            // 
            // uscEliminarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tlpEliminarPedido);
            this.Name = "uscEliminarPedido";
            this.Size = new System.Drawing.Size(568, 467);
            this.Load += new System.EventHandler(this.uscEliminarPedido_Load);
            this.tlpEliminarPedido.ResumeLayout(false);
            this.tlpEliminarPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEliminarPedido;
        private System.Windows.Forms.Label lblOrden;
        private System.Windows.Forms.ComboBox cmbOrdenes;
        private System.Windows.Forms.Button btnRealizarOrden;
    }
}
