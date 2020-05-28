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
        private string username = "";
        private UserControl currentD = new UserControl();
        public frmAccesoNormal()
        {
            InitializeComponent();
        }

        public frmAccesoNormal(string un)
        {
            InitializeComponent();
            currentD = uscAnadirDireccion1;
            username = un;
        }

        private void frmAccesoNormal_Load(object sender, EventArgs e)
        {
            tlpDirecciones.Controls.Remove(currentD);
            currentD = new uscAnadirDireccion();
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
