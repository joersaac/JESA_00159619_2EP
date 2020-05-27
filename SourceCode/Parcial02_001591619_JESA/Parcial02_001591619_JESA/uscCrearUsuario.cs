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
    public partial class uscCrearUsuario : UserControl
    {
        public uscCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrearU_Click(object sender, EventArgs e)
        {
            if (txbFullName.Text.Equals("") || txbUserName.Text.Equals(""))
            {
                MessageBox.Show("No se puden dejar campos vacios!");
            }
            else
            {
                if (Comprobaruser(txbUserName.Text))
                {
                    MessageBox.Show("Usuario con ese nombre ya existe!");
                }
                else
                {
                    try
                    {
                        ConnectionDB.ExecuteNonQuery("INSERT INTO appuser(fullname,username,password,userType) " +
                            $"VALUES ('{txbFullName.Text}','{txbUserName.Text}'," +
                            $"'{txbUserName.Text}',{radAdmin.Checked})");
                        MessageBox.Show("Se ha ingresado al usuario!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error!");
                    }
                }
            }
        }

        private void uscCrearUsuario_Load(object sender, EventArgs e)
        {
            radNormal.Checked = true;
        }

        private bool Comprobaruser(string nombreUsuario)
        {
            var users = ConnectionDB.ExecuteQuery("SELECT username FROM appuser");
            var usersCombo = new List<string>();

            foreach (DataRow dr in users.Rows)
            {
                if (nombreUsuario.Equals(dr[0].ToString())){
                    return true;
                }
            }
            return false;
        }
    }
}
