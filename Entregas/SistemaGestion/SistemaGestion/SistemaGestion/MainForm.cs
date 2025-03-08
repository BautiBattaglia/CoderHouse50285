using SistemaGestion;
using System;
using System.Windows.Forms;

namespace SistemaGestionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var usuarioForm = new UsuarioForm();
            usuarioForm.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var productoForm = new ProductoForm();
            productoForm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var ventaForm = new VentaForm();
            ventaForm.Show();
        }

        private void btnProductosVendidos_Click(object sender, EventArgs e)
        {
            var productoVendidoForm = new ProductoVendidoForm();
            productoVendidoForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
