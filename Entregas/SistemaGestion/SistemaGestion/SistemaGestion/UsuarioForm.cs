using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var usuarioFormAgregar = new UsuarioFormAgregar();
            usuarioFormAgregar.Show();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            var usuarioFormBuscar = new UsuarioFormBuscar();
            usuarioFormBuscar.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var usuarioFormEliminar = new UsuarioFormEliminar();
            usuarioFormEliminar.Show();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            var usuarioFormModificar = new UsuarioFormModificar();
            usuarioFormModificar.Show();
        }
    }
}
