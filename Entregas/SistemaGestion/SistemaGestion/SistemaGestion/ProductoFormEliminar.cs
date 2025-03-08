using System;
using System.Net.Http;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class ProductoFormEliminar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Producto";

        public ProductoFormEliminar()
        {
            InitializeComponent();
        }

        private async void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            var id = txtProductoID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }

            try
            {
                var response = await client.DeleteAsync($"{apiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el producto: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el producto: {ex.Message}");
            }
        }
    }
}
