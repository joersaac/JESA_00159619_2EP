using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02_001591619_JESA
{
    public partial class uscEliminarUsuario : UserControl
    {
        public uscEliminarUsuario()
        {
            InitializeComponent();
        }

        private void uscEliminarUsuario_Load(object sender, EventArgs e)
        {
            Load_list();
        }

        private void Load_list()
        {
            var users = ConnectionDB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUsuario.DataSource = usersCombo;
        }
    }
}
