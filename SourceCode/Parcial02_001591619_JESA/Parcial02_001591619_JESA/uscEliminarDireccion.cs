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
    public partial class uscEliminarDireccion : UserControl
    {
        public uscEliminarDireccion()
        {
            InitializeComponent();
        }

        private void uscEliminarDireccion_Load(object sender, EventArgs e)
        {
            Load_list();
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

        private void btnEliminar_Click(object sender, EventArgs e)
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

                ConnectionDB.ExecuteNonQuery("DELETE FROM   address " +
                    $"WHERE idaddress={auxid}");
                MessageBox.Show("Se ha eliminado la direccion!");
                Load_list();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
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
