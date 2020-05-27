using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial02_001591619_JESA
{
    public partial class frmCambioContra : Form
    {
        public frmCambioContra()
        {
            InitializeComponent();
        }

        private void frmCambioContra_Load(object sender, EventArgs e)
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
            if (txbContrasenaActual.Text.Equals("") || txbContrasenaNew.Text.Equals("") 
                || txbRepetirContra.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios!");
            }
            else
            {
                if (txbContrasenaNew.Text.Equals(txbContrasenaActual.Text))
                {
                    MessageBox.Show("Contraseña nueva no puede ser la misma que contraseña actual!");
                }
                else
                {
                    try
                    {
                        string auxname = cmbUsuario.SelectedItem.ToString();
                        var auxpassword = ConnectionDB.ExecuteQuery("SELECT password FROM appuser " +
                                                                    $"WHERE username = '{auxname}'");
                        var dr = auxpassword.Rows[0];
                        string oldPassword = dr[0].ToString();

                        if (oldPassword.Equals(txbContrasenaActual.Text))
                        {
                            if (txbContrasenaNew.Text.Equals(txbRepetirContra.Text))
                            {
                                string newPassword = txbContrasenaNew.Text;
                                ConnectionDB.ExecuteNonQuery($"UPDATE appuser " +
                                                             $"SET password = '{newPassword}' " +
                                                             $"WHERE username ='{auxname}'");
                                MessageBox.Show("Contraseña cambiada con exito!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Nueva contraseña no coinicde!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Contraseña actual escrita es invalida!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un ERROR!");
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
