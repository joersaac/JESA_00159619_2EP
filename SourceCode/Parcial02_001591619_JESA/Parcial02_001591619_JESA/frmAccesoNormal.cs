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
    public partial class frmAccesoNormal : Form
    {
        private UserControl currentD = new UserControl();
        public frmAccesoNormal()
        {
            InitializeComponent();
            currentD = uscAnadirDireccion1;
        }

        private void frmAccesoNormal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            tlpDirecciones.Controls.Remove(currentD);
            currentD = uscAnadirDireccion1;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uscModificarDireccion md = new uscModificarDireccion();
            tlpDirecciones.Controls.Remove(currentD);
            currentD = md;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            uscEliminarDireccion ed = new uscEliminarDireccion();
            tlpDirecciones.Controls.Remove(currentD);
            currentD = ed;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
