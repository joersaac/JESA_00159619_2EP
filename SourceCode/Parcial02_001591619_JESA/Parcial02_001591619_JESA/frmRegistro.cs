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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            Load_list();
        }

        private void Load_list()
        {
            var users = ConnectionDB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                usersCombo.Add(dr[0].ToString());
            }

            cmbUsuario.DataSource = usersCombo;
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            frmCambioContra newWindow = new frmCambioContra();
            newWindow.ShowDialog();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txbContrasena.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar caampos vacios!");
            }
            else
            {
                try
                {
                    string auxname = cmbUsuario.SelectedItem.ToString();

                    var dt = ConnectionDB.ExecuteQuery("SELECT password FROM appuser " +
                                                                $"WHERE username = '{auxname}'");
                    var dr = dt.Rows[0];
                    string auxPassword = dr[0].ToString();

                    var dta = ConnectionDB.ExecuteQuery("SELECT usertype FROM appuser " +
                                                       $"WHERE username = '{auxname}'");
                    var dra = dta.Rows[0];
                    bool auxAcceso = Convert.ToBoolean(dra[0].ToString());

                    if (txbContrasena.Text.Equals(auxPassword))
                    {
                        if (auxAcceso)
                        {
                            frmAccesoAdmin newWindow = new frmAccesoAdmin();
                            newWindow.ShowDialog();
                            Load_list();
                        }
                        else
                        {
                            frmAccesoNormal newWindow = new frmAccesoNormal());
                            newWindow.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña ingresada invalida!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un ERROR!");
                }
            }
        }
    }
}
