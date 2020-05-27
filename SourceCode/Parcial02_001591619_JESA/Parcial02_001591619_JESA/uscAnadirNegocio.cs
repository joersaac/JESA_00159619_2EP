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
    public partial class uscAnadirNegocio : UserControl
    {
        public uscAnadirNegocio()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txbBusiName.Text.Equals("") || txbDescripcion.Text.Equals(""))
            {
                MessageBox.Show("No se puden dejar campos vacios!");
            }
            else
            {
                if (ComprobarNegocio(txbBusiName.Text))
                {
                    MessageBox.Show("Negocio con ese nombre ya existe!");
                }
                else
                {
                    try
                    {
                        ConnectionDB.ExecuteNonQuery("INSERT INTO business(name,description) " +
                            $"VALUES ('{txbBusiName.Text}','{txbDescripcion.Text}')");
                        MessageBox.Show("Se ha ingresado el negocio!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }
        private bool ComprobarNegocio(string nombreNegocio)
        {
            var users = ConnectionDB.ExecuteQuery("SELECT name FROM business");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                if (nombreNegocio.Equals(dr[0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
