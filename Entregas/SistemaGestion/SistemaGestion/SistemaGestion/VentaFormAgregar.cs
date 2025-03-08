using Newtonsoft.Json;
using SistemaGestionEntities;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class VentaFormAgregar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Venta";

        public VentaFormAgregar()
        {
            InitializeComponent();
        }

        private async void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            // Validar y recopilar los datos del formulario
            if (int.TryParse(txtIdCliente.Text, out int usuarioId) &&
                decimal.TryParse(txtMontoTotal.Text, out decimal montoTotal))
            {
                var venta = new Venta
                {
                    UsuarioId = usuarioId,
                    Fecha = DateTime.Now, // o la fecha que desees
                    MontoTotal = montoTotal
                };

                var json = JsonConvert.SerializeObject(venta);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(apiUrl, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta agregada con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar venta: " + responseString);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la API: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos para el ID del Cliente y el Monto Total.");
            }
        }
    }
}
