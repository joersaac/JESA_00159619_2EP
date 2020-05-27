namespace Parcial02_001591619_JESA
{
    partial class uscCrearUsuario
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
            this.tlpCrearUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTipoAcces = new System.Windows.Forms.Label();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.txbTipoAcces = new System.Windows.Forms.TextBox();
            this.tlpCrearUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCrearUsuario
            // 
            this.tlpCrearUsuario.ColumnCount = 3;
            this.tlpCrearUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCrearUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCrearUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCrearUsuario.Controls.Add(this.lblFullName, 0, 1);
            this.tlpCrearUsuario.Controls.Add(this.btnCrearU, 0, 7);
            this.tlpCrearUsuario.Controls.Add(this.lblUserName, 0, 3);
            this.tlpCrearUsuario.Controls.Add(this.lblTipoAcces, 0, 5);
            this.tlpCrearUsuario.Controls.Add(this.txbFullName, 1, 1);
            this.tlpCrearUsuario.Controls.Add(this.txbUserName, 1, 3);
            this.tlpCrearUsuario.Controls.Add(this.txbTipoAcces, 1, 5);
            this.tlpCrearUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCrearUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlpCrearUsuario.Name = "tlpCrearUsuario";
            this.tlpCrearUsuario.RowCount = 9;
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlpCrearUsuario.Size = new System.Drawing.Size(688, 462);
            this.tlpCrearUsuario.TabIndex = 0;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(63, 62);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(218, 29);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Nombre Completo:";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCrearU
            // 
            this.btnCrearU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearU.BackColor = System.Drawing.Color.SlateBlue;
            this.tlpCrearUsuario.SetColumnSpan(this.btnCrearU, 3);
            this.btnCrearU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearU.ForeColor = System.Drawing.Color.White;
            this.btnCrearU.Location = new System.Drawing.Point(242, 362);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(204, 41);
            this.btnCrearU.TabIndex = 7;
            this.btnCrearU.Text = "Crear";
            this.btnCrearU.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(59, 164);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(226, 29);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Nombre de usuario:";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipoAcces
            // 
            this.lblTipoAcces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipoAcces.AutoSize = true;
            this.lblTipoAcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoAcces.ForeColor = System.Drawing.Color.White;
            this.lblTipoAcces.Location = new System.Drawing.Point(79, 266);
            this.lblTipoAcces.Name = "lblTipoAcces";
            this.lblTipoAcces.Size = new System.Drawing.Size(186, 29);
            this.lblTipoAcces.TabIndex = 9;
            this.lblTipoAcces.Text = "Tipo de acceso:";
            this.lblTipoAcces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbFullName
            // 
            this.txbFullName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpCrearUsuario.SetColumnSpan(this.txbFullName, 2);
            this.txbFullName.Location = new System.Drawing.Point(402, 63);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(227, 26);
            this.txbFullName.TabIndex = 10;
            // 
            // txbUserName
            // 
            this.txbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpCrearUsuario.SetColumnSpan(this.txbUserName, 2);
            this.txbUserName.Location = new System.Drawing.Point(402, 165);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(227, 26);
            this.txbUserName.TabIndex = 11;
            // 
            // txbTipoAcces
            // 
            this.txbTipoAcces.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpCrearUsuario.SetColumnSpan(this.txbTipoAcces, 2);
            this.txbTipoAcces.Location = new System.Drawing.Point(402, 267);
            this.txbTipoAcces.Name = "txbTipoAcces";
            this.txbTipoAcces.Size = new System.Drawing.Size(227, 26);
            this.txbTipoAcces.TabIndex = 12;
            // 
            // uscCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Controls.Add(this.tlpCrearUsuario);
            this.Name = "uscCrearUsuario";
            this.Size = new System.Drawing.Size(688, 462);
            this.tlpCrearUsuario.ResumeLayout(false);
            this.tlpCrearUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCrearUsuario;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnCrearU;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblTipoAcces;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.TextBox txbTipoAcces;
    }
}
