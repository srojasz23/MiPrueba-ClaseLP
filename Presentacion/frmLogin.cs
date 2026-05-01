using Negocio.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new UsuarioBLL();
                var user = bll.Login(txtUser.Text, txtPass.Text);

                MessageBox.Show($"Bienvenido {user.NombreUsuario}");

                this.Hide();

                // este es el cambio 
                new frmPrincipal(user.NombreUsuario, user.Rol).Show();

            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
