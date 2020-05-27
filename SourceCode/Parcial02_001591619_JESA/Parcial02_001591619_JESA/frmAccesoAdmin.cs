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
        private UserControl current = new UserControl();
        private uscEliminarUsuario eu = new uscEliminarUsuario();
        public frmAccesoAdmin()
        {
            InitializeComponent();
            current = uscCrearUsuario1;
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
            tloMantenimientoU.Controls.Remove(current);
            current = eu;
            tloMantenimientoU.Controls.Add(current, 1, 0);
            tloMantenimientoU.SetColumnSpan(current, 2);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            tloMantenimientoU.Controls.Remove(current);
            current = uscCrearUsuario1;
            tloMantenimientoU.Controls.Add(current, 1, 0);
            tloMantenimientoU.SetColumnSpan(current, 2);
            current.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadUserList();
        }
    }
}
