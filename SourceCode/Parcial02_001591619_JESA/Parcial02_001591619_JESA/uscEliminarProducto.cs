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
    public partial class uscEliminarProducto : UserControl
    {
        public uscEliminarProducto()
        {
            InitializeComponent();
        }

        private void uscEliminarProducto_Load(object sender, EventArgs e)
        {
            Load_list();
        }

        private void Load_list()
        {
            var products = ConnectionDB.ExecuteQuery("SELECT idproduct,name FROM product");
            var ProductCombo = new List<string>();

            foreach (DataRow dr in products.Rows)
            {
                ProductCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
            }

            cmbProductos.DataSource = ProductCombo;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxComboBox = "";
                int limite = LimiteFinal(cmbProductos.SelectedItem.ToString());
                if (limite < 0)
                    auxComboBox += cmbProductos.SelectedItem.ToString().Substring(0, limite);
                else
                    auxComboBox +=cmbProductos.SelectedItem.ToString()[0];
                int auxid = 0;
                auxid = Convert.ToInt16(auxComboBox);
                ConnectionDB.ExecuteNonQuery("DELETE FROM product " +
                                             $"WHERE idproduct ={auxid}");
                MessageBox.Show("Se eleimino el producto!");
                Load_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un ERROR!");
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
    }
}
