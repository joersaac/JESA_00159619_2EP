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
    public partial class uscAnadirDireccion : UserControl
    {
        private string username;
        public uscAnadirDireccion()
        {
            InitializeComponent();
            username = ControlDeUsuario.DevolverUserName();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txbDireccion.Text.Equals(""))
            {
                MessageBox.Show("No se puden dejar campos vacios!");
            }
            else
            {
                if (ComprobarDireccion(txbDireccion.Text))
                {
                    MessageBox.Show("Direccion ya ha sido agregada!");
                }
                else
                {
                    try
                    {
                        ConnectionDB.ExecuteNonQuery("INSERT INTO address(iduser,address) " +
                            $"VALUES ({OptenerId()},'{txbDireccion.Text}')");
                        MessageBox.Show("Se ha ingresado la direccion!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }
        private bool ComprobarDireccion(string nombreNegocio)
        {
            int auxid = OptenerId();
            var users = ConnectionDB.ExecuteQuery("SELECT address FROM address " +
                $"WHERE iduser = {auxid}");
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

        private int OptenerId()
        {
            var dti = ConnectionDB.ExecuteQuery("SELECT iduser FROM appuser " +
                $"WHERE username='{username}'");
            var dri = dti.Rows[0];
            string auxstr = dri[0].ToString();
            int auxid = Convert.ToInt16(auxstr);
            return auxid;
        }

        private void uscAnadirDireccion_Load(object sender, EventArgs e)
        {

        }
    }
}
