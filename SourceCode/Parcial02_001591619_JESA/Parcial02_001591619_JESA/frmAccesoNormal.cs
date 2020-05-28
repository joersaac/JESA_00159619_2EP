using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02_001591619_JESA
{
    public partial class frmAccesoNormal : Form
    {
        private UserControl currentD = new UserControl();
        private UserControl currentO = new UserControl();
        public frmAccesoNormal()
        {
            InitializeComponent();
            currentD = uscAnadirDireccion1;
            currentO = uscRealizarOrden1;
        }

        private void frmAccesoNormal_Load(object sender, EventArgs e)
        {
            LoadHistorial();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            tlpDirecciones.Controls.Remove(currentD);
            currentD = uscAnadirDireccion1;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uscModificarDireccion md = new uscModificarDireccion();
            tlpDirecciones.Controls.Remove(currentD);
            currentD = md;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnEliminarD_Click(object sender, EventArgs e)
        {
            uscEliminarDireccion ed = new uscEliminarDireccion();
            tlpDirecciones.Controls.Remove(currentD);
            currentD = ed;
            tlpDirecciones.Controls.Add(currentD, 1, 0);
            tlpDirecciones.SetColumnSpan(currentD, 3);
            currentD.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            LoadHistorial();
        }

        private void LoadHistorial()
        {

            var dti = ConnectionDB.ExecuteQuery("SELECT iduser FROM appuser " +
                $"WHERE username = '{ControlDeUsuario.DevolverUserName()}'");
            var dri = dti.Rows[0];
            int auxid = Convert.ToInt16(dri[0].ToString());
            var dt= ConnectionDB.ExecuteQuery("SELECT idaddress,address FROM address " +
                $"WHERE iduser = {auxid}");
            dgvDirecciones.DataSource = dt;
            var dt2 = ConnectionDB.ExecuteQuery("SELECT app.idorder,apu.fullname,adr.address," +
                "pro.name,bus.name,app.createdate " +
                "FROM APPORDER app, PRODUCT pro, APPUSER apu, ADDRESS adr, BUSINESS bus " +
                "WHERE app.idaddress = adr.idaddress AND adr.iduser = apu.iduser " +
                $"AND apu.iduser = {auxid} AND app.idproduct = pro.idproduct AND pro.idbusiness = bus.idbusiness");
            dgvOrdenes.DataSource = dt2;
        }

        private void btnRefrescarO_Click(object sender, EventArgs e)
        {
            LoadHistorial();
        }

        private void btnRealizarOrden_Click(object sender, EventArgs e)
        {
            tlpOrdenes.Controls.Remove(currentO);
            currentO= new uscRealizarOrden();
            tlpOrdenes.Controls.Add(currentO, 1, 0);
            tlpOrdenes.SetColumnSpan(currentO, 2);
            currentO.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void btnEliminarO_Click(object sender, EventArgs e)
        {
            uscEliminarPedido eo = new uscEliminarPedido();
            tlpOrdenes.Controls.Remove(currentO);
            currentO = eo;
            tlpOrdenes.Controls.Add(currentO, 1, 0);
            tlpOrdenes.SetColumnSpan(currentO, 2);
            currentO.Dock = System.Windows.Forms.DockStyle.Fill;
        }
    }
}
