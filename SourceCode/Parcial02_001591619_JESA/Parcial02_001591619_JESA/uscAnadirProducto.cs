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
    public partial class uscAnadirProducto : UserControl
    {
        public uscAnadirProducto()
        {
            InitializeComponent();
        }

        private void uscAnadirProducto_Load(object sender, EventArgs e)
        {
            Load_list();
        }

        private void Load_list()
        {
            var business = ConnectionDB.ExecuteQuery("SELECT idbusiness,name FROM business");
            var businessCombo = new List<string>();

            foreach (DataRow dr in business.Rows)
            {
                businessCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
            }

            cmbNegocios.DataSource = businessCombo;
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (txbItemName.Text.Equals(""))
            {
                MessageBox.Show("No se puden dejar campos vacios!");
            }
            else
            {
                try
                {
                    string auxComboBox = "";
                    int limite = LimiteFinal(cmbNegocios.SelectedItem.ToString());
                    if (limite < 0)
                        auxComboBox += cmbNegocios.SelectedItem.ToString().Substring(0,limite);
                    else
                        auxComboBox += cmbNegocios.SelectedItem.ToString()[0];                   
                    int auxid = 0;
                    auxid = Convert.ToInt16(auxComboBox);
                    if (ComprobarPoducto(txbItemName.Text, auxid))
                    {
                        MessageBox.Show("Producto ya existe en negocio!");
                    }
                    else
                    {
                        ConnectionDB.ExecuteNonQuery("INSERT INTO product(idbusiness,name) " +
                            $"VALUES ( {auxid},'{txbItemName.Text}')");
                        MessageBox.Show("Se ha ingresado el producto!");
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
        private bool ComprobarPoducto(string nombreNegocio,int idproduct)
        {
            var users = ConnectionDB.ExecuteQuery("SELECT name FROM product " +
                $"WHERE idbusiness={idproduct}");
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
