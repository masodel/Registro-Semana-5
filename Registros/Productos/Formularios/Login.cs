using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.Formularios
{
    public partial class Login : Form
    {
        UsuarioDao users = new UsuarioDao();
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (users.Validar(tbUsuario.Text, tbContrasena.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
