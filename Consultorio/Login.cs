using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
//para poder utilizar las instrucciones de SQL
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Consultorio
{
    public partial class Login : Form
    {

        


        public Login()
        {
            InitializeComponent();
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Baceptar_Click(object sender, EventArgs e)
        {
            if (tbusuario.Text != "NUsuario")
            {
                if (tbcontrasena.Text != "Contrasena")
                {
                    ModeloUsuario user = new ModeloUsuario();
                    var validlogin = user.LoginUser(tbusuario.Text, tbcontrasena.Text);
                    if (validlogin==true)
                    {
                        FMenu fMenu = new FMenu();
                        fMenu.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario y contraseña incorrectos");
                        tbusuario.Clear();
                        tbcontrasena.Clear();
                        tbusuario.Focus();
                    }
                }

                else msgError("Digite el nombre de usuario");
            }

            else msgError("Digite la contraseña");
        }
        
        private void msgError(string msg)
        {
            IbIErrorMessage.Text = "   " + msg;
            IbIErrorMessage.Visible = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
