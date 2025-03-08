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
    public partial class ProductoForm : Form
    {
        public ProductoForm()
        {
            InitializeComponent();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var productoFormAgregar = new ProductoFormAgregar();
            productoFormAgregar.Show();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var productoFormBuscar = new ProductoFormBuscar();
            productoFormBuscar.Show();
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            var productoFormModificar = new ProductoFormModificar();
            productoFormModificar.Show();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var productoFormEliminar = new ProductoFormEliminar();
            productoFormEliminar.Show();
        }
    }
}
