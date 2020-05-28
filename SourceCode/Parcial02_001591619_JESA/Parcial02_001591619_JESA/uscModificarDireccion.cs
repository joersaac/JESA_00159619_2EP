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
    public partial class uscModificarDireccion : UserControl
    {
        private string username;
        public uscModificarDireccion()
        {
            InitializeComponent();
            username = ControlDeUsuario.DevolverUserName();
        }

        private void Load_list()
        {
            var business = ConnectionDB.ExecuteQuery("SELECT idaddress,address FROM address");
            var businessCombo = new List<string>();

            foreach (DataRow dr in business.Rows)
            {
                businessCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
            }

            cmbDirrecion.DataSource = businessCombo;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txbDireccion.Text.Equals(""))
            {
                MessageBox.Show("No se puden dejar campos vacios!");
            }
            else
            {
                try
                {
                    string auxComboBox = "";
                    int limite = LimiteFinal(cmbDirrecion.SelectedItem.ToString());
                    if (limite < 0)
                        auxComboBox += cmbDirrecion.SelectedItem.ToString().Substring(0, limite);
                    else
                        auxComboBox += cmbDirrecion.SelectedItem.ToString()[0];
                    int auxid = Convert.ToInt16(auxComboBox);
                    if (ComprobarDireccion(txbDireccion.Text, auxid))
                    {
                        MessageBox.Show("Direccion ya existe!");
                    }
                    else
                    {
                        ConnectionDB.ExecuteNonQuery("UPDATE address " +
                            $"SET address = '{txbDireccion.Text}' " +
                            $"WHERE idaddress={auxid}");
                        MessageBox.Show("Se ha modificado la direccion!");
                        Load_list();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!");
                }
            }
        }
        private int LimiteFinal(string cadenatext)
        {
            int limite = -1;
            foreach (var n in cadenatext)
            {
                if (n == ' ')
                    return limite;
                else
                    limite++;
            }
            return limite;
        }

        private void uscModificarDireccion_Load(object sender, EventArgs e)
        {
            Load_list();
        }

        private bool ComprobarDireccion(string address, int idaddress)
        {
            var users = ConnectionDB.ExecuteQuery("SELECT address FROM address " +
                $"WHERE iaddress={idaddress}");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                if (address.Equals(dr[0].ToString()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
