using Newtonsoft.Json;
using SistemaGestionEntities;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class ProductoFormBuscar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Producto";

        public ProductoFormBuscar()
        {
            InitializeComponent();
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var id = txtProductoID.Text;
            try
            {
                var response = await client.GetStringAsync(apiUrl + $"/{id}");

                var producto = JsonConvert.DeserializeObject<Producto>(response);

                txtNombre.Text = producto.Nombre;
                txtPrecio.Text = producto.Precio.ToString(); 
                txtStock.Text = producto.Stock.ToString(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el producto: {ex.Message}");
            }
        }

        private void ProductoFormBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
