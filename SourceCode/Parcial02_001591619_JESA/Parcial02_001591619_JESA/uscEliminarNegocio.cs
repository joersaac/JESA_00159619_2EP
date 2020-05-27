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
    public partial class uscEliminarNegocio : UserControl
    {
        public uscEliminarNegocio()
        {
            InitializeComponent();
        }

        private void uscEliminarNegocio_Load(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string auxComboBox = "";
                auxComboBox += cmbNegocios.SelectedItem.ToString()[0];
                int limite = LimiteFinal(auxComboBox);
                int auxid = 0;
                if (limite < 0)
                    auxid=Convert.ToInt16(auxComboBox.Substring(0,limite));
                else
                    auxid = Convert.ToInt16(auxComboBox[0]);
                ConnectionDB.ExecuteNonQuery("DELETE FROM business " +
                                             $"WHERE idbusiness ={auxid}");
                MessageBox.Show("Se eleimino el negocio!");
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
