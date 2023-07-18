using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            if (ValidarUsuario() == false || ValidarContraseña() == false) { return; }


            Menu formMenu = new Menu();
            formMenu.Show();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            ValidarUsuario();
        }

        private bool ValidarUsuario()
        {
            if ((string.IsNullOrEmpty(txtUsuario.Text)))
            {
                errorProvider1.SetError(txtUsuario, "ingresar su usuario");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "");
                return true;
            }

        }

        private void txtContraseña_Validating(object sender, CancelEventArgs e)
        {
            ValidarContraseña();
        }

        private bool ValidarContraseña()
        {
            if ((string.IsNullOrEmpty(txtContraseña.Text)))
            {
                errorProvider1.SetError(txtContraseña, "Ingrese una contraseña");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtContraseña, "");
                return true;
            }

           
        }

    }
}
