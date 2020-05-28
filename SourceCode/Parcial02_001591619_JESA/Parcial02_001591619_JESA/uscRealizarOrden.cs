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
    public partial class uscRealizarOrden : UserControl
    {
        public uscRealizarOrden()
        {
            InitializeComponent();
        }

        private void uscRealizarOrden_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            try
            {
                var dti = ConnectionDB.ExecuteQuery("SELECT iduser FROM appuser " +
                    $"WHERE username = '{ControlDeUsuario.DevolverUserName()}'");
                var dri = dti.Rows[0];
                int auxidu = Convert.ToInt16(dri[0].ToString());

                var direcciones = ConnectionDB.ExecuteQuery("SELECT idaddress,address FROM address " +
                    $"WHERE iduser = {auxidu}");
                var direccionesCombo = new List<string>();

                var negocios = ConnectionDB.ExecuteQuery("SELECT idbusiness,name FROM business");
                var negocosCombo = new List<string>();

                foreach (DataRow dr in direcciones.Rows)
                {
                    direccionesCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
                }

                foreach (DataRow dr in negocios.Rows)
                {
                    negocosCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
                }

                cmbDirecciones.DataSource = direccionesCombo;
                cmbNegocios.DataSource = negocosCombo;

                string auxcadena = cmbNegocios.SelectedItem.ToString();
                int auxlim = LimiteFinal(auxcadena);
                int auxid = 0;
                if (auxlim > 0)
                    auxid = Convert.ToInt16(auxcadena.Substring(0, auxlim));
                else
                    auxid = Convert.ToInt16($"{auxcadena[0]}");

                var producto = ConnectionDB.ExecuteQuery("SELECT idproduct,name FROM product " +
                    $"WHERE idbusiness = {auxid}");
                var productoCombo = new List<string>();

                foreach (DataRow dr in producto.Rows)
                {
                    productoCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
                }
                cmbProductos.DataSource = productoCombo;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un erro al cargar las listas!");
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

        private List<string> productos()
        {
            string auxcadena = cmbNegocios.SelectedItem.ToString();
            int auxlim = LimiteFinal(auxcadena);
            int auxid = 0;
            if (auxlim > 0)
                auxid = Convert.ToInt16(auxcadena.Substring(0, auxlim));
            else
                auxid = Convert.ToInt16($"{auxcadena[0]}");

            var producto = ConnectionDB.ExecuteQuery("SELECT idproduct,name FROM product " +
                $"WHERE idbusiness = {auxid}");
            var productoCombo = new List<string>();

            foreach (DataRow dr in producto.Rows)
            {
                productoCombo.Add(dr[0].ToString() + " " + dr[1].ToString());
            }

            return productoCombo;

        }

        private void cmbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProductos.DataSource = productos();
        }

        private void btnRealizarOrden_Click(object sender, EventArgs e)
        {
            try
            {
                string comboProducto = cmbProductos.SelectedItem.ToString();
                string comboDireccion = cmbDirecciones.SelectedItem.ToString();
                int idProducto = 0;
                int idDireccion = 0;
                int auxlim = LimiteFinal(comboProducto);
                if (auxlim > 0)
                    idProducto = Convert.ToInt16(comboProducto.Substring(0, auxlim));
                else
                    idProducto = Convert.ToInt16($"{comboProducto[0]}");
                if(auxlim > 0)
                    idDireccion = Convert.ToInt16(comboDireccion.Substring(0, auxlim));
                else
                    idDireccion = Convert.ToInt16($"{comboDireccion[0]}");
                ConnectionDB.ExecuteNonQuery("INSERT INTO apporder(createdate,idproduct,idaddress) " +
                    $"VALUES ('{DateTime.Now}',{idProducto},{idDireccion})");
                MessageBox.Show("Se ha realizado el pedido");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error!");
            }
        }
    }
}
