using Newtonsoft.Json;
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
    public partial class ProductoFormAgregar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Producto";


        public ProductoFormAgregar()
        {
            InitializeComponent();
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //Creamos un objeto con los datos que recopilamos de los campos del form
            var producto = new
            {
                Nombre = txtNombre.Text,
                Precio = txtPrecio.Text,
                Stock = txtStock.Text,
            };

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(producto);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(apiUrl, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Producto agregado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar producto: " + responseString);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la API: " + ex.Message);
                }
            }

        }
    }
}
