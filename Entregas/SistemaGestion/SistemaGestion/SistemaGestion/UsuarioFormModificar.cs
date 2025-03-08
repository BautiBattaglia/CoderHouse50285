using Newtonsoft.Json;
using SistemaGestionEntities;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class UsuarioFormModificar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Usuario";

        public UsuarioFormModificar()
        {
            InitializeComponent();
        }

        private async void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            var id = txtUsuarioID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                return;
            }

            try
            {
                var response = await client.GetStringAsync($"{apiUrl}/{id}");
                var usuario = JsonConvert.DeserializeObject<Usuario>(response);

                if (usuario != null)
                {
                    txtNombre.Text = usuario.Nombre;
                    txtApellido.Text = usuario.Apellido;
                    txtEmail.Text = usuario.Email;
                    txtPassword.Text = usuario.Password;
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el usuario: {ex.Message}");
            }
        }

        private async void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            var id = txtUsuarioID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                return;
            }

            var usuario = new Usuario
            {
                Id = int.Parse(id),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };

            try
            {
                var json = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{apiUrl}/{id}", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario modificado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"Error al modificar el usuario: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el usuario: {ex.Message}");
            }
        }
    }
}
