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
    public partial class uscEliminarPedido : UserControl
    {
        public uscEliminarPedido()
        {
            InitializeComponent();
        }

        private void uscEliminarPedido_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            var dti = ConnectionDB.ExecuteQuery("SELECT iduser FROM appuser " +
                $"WHERE username = '{ControlDeUsuario.DevolverUserName()}'");
            var dri = dti.Rows[0];
            int auxidu = Convert.ToInt16(dri[0].ToString());

            var ordenes = ConnectionDB.ExecuteQuery("SELECT app.idorder,adr.address," +
                "pro.name,bus.name,app.createdate " +
                "FROM APPORDER app, PRODUCT pro, APPUSER apu, ADDRESS adr, BUSINESS bus " +
                $"WHERE app.idaddress = adr.idaddress AND adr.iduser = apu.iduser AND apu.iduser = {auxidu}" +
                "AND app.idproduct = pro.idproduct AND pro.idbusiness = bus.idbusiness");
            var ordenesCombo = new List<string>();

            foreach (DataRow dr in ordenes.Rows)
            {
                ordenesCombo.Add(dr[0].ToString() + " " + dr[1].ToString() + " " + 
                    dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString());
            }
            cmbOrdenes.DataSource = ordenesCombo;           
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

        private void btnRealizarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                string auxComboBox = "";
                int limite = LimiteFinal(cmbOrdenes.SelectedItem.ToString());
                if (limite < 0)
                    auxComboBox += cmbOrdenes.SelectedItem.ToString().Substring(0, limite);
                else
                    auxComboBox += cmbOrdenes.SelectedItem.ToString()[0];
                int auxid = 0;
                auxid = Convert.ToInt16(auxComboBox);
                ConnectionDB.ExecuteNonQuery("DELETE FROM apporder " +
                                             $"WHERE idorder ={auxid}");
                MessageBox.Show("Se eleimino la orden!");
                LoadComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un ERROR!");
            }
        }
    }
}
