using Newtonsoft.Json;
using SistemaGestionEntities;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class ProductoFormModificar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Producto";

        public ProductoFormModificar()
        {
            InitializeComponent();
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var id = txtProductoID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }

            try
            {
                var response = await client.GetStringAsync($"{apiUrl}/{id}");
                var producto = JsonConvert.DeserializeObject<Producto>(response);

                if (producto != null)
                {
                    txtNombre.Text = producto.Nombre;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtStock.Text = producto.Stock.ToString();
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el producto: {ex.Message}");
            }
        }

        private async void btnModificarProducto_Click(object sender, EventArgs e)
        {
            var id = txtProductoID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de producto válido.");
                return;
            }

            var producto = new Producto
            {
                Id = int.Parse(id),
                Nombre = txtNombre.Text,
                Precio = decimal.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text)
            };

            try
            {
                var json = JsonConvert.SerializeObject(producto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{apiUrl}/{id}", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Producto modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"Error al modificar el producto: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}");
            }
        }

        private void ProductoFormModificar_Load(object sender, EventArgs e)
        {

        }
    }
}
