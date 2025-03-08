using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using SistemaGestionEntities;

namespace SistemaGestion
{
    public partial class UsuarioFormBuscar : Form
    {

        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Usuario";

        public UsuarioFormBuscar()
        {
            InitializeComponent();
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUsuarioID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            try
            {
                // Realiza la llamada al API
                var response = await client.GetAsync(apiUrl + $"/{id}");

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Error: {response.StatusCode}. No se pudo recuperar el usuario.");
                    return;
                }

                // Leer el contenido de la respuesta
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserializa la respuesta del servidor en un objeto Usuario
                var usuario = JsonConvert.DeserializeObject<Usuario>(responseContent);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario no encontrado.");
                    return;
                }

                // Actualiza los campos del formulario con la información del usuario
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                txtPassword.Text = usuario.Password;  // Sólo si es seguro mostrar la contraseña
                txtEmail.Text = usuario.Email;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("Error al realizar la solicitud HTTP: " + ex.Message);
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Error al procesar la respuesta del servidor: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
        }

        private void UsuarioFormBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
