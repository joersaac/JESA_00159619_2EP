using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02_001591619_JESA
{
    public partial class frmAccesoAdmin : Form
    {
        private UserControl currentU = new UserControl();
        private UserControl currentN = new UserControl();
  
        public frmAccesoAdmin()
        {
            InitializeComponent();
            currentU = uscCrearUsuario1;
            currentN = uscAnadirNegocio1;
        }

        private void frmAccesoAdmin_Load(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void LoadUserList()
        {
            try
            {
                var dt = ConnectionDB.ExecuteQuery($"SELECT iduser, fullname, username FROM appuser");
                dgvUsuario.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            uscEliminarUsuario eu = new uscEliminarUsuario();
            tlpMantenimientoU.Controls.Remove(currentU);
            currentU = eu;
            tlpMantenimientoU.Controls.Add(currentU, 1, 0);
            tlpMantenimientoU.SetColumnSpan(currentU, 2);
            currentU.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            tlpMantenimientoU.Controls.Remove(currentU);
            currentU = uscCrearUsuario1;
            tlpMantenimientoU.Controls.Add(currentU, 1, 0);
            tlpMantenimientoU.SetColumnSpan(currentU, 2);
            currentU.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }

        private void btnAnadirN_Click(object sender, EventArgs e)
        {
            tlpMantenimientoN.Controls.Remove(currentN);
            currentN = uscAnadirNegocio1;
            tlpMantenimientoN.Controls.Add(currentN, 0, 0);
            tlpMantenimientoN.SetColumnSpan(currentN, 2);
            currentN.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnEliminarN_Click(object sender, EventArgs e)
        {
            uscEliminarNegocio en = new uscEliminarNegocio();
            tlpMantenimientoN.Controls.Remove(currentN);
            currentN = en;
            tlpMantenimientoN.Controls.Add(currentN, 0, 0);
            tlpMantenimientoN.SetColumnSpan(currentN, 2);
            currentN.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
