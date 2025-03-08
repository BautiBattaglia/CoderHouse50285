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
    public partial class UsuarioFormAgregar : Form
    {

        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Usuario";

        public UsuarioFormAgregar()
        {
            InitializeComponent();
        }

        private void UsuarioFormAgregar_Load(object sender, EventArgs e)
        {

        }

        private async void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //Creamos un objeto con los datos que recopilamos de los campos del form
            var usuario = new
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text
            };

            using (var client = new HttpClient())
            {
                var json = JsonConvert.SerializeObject(usuario);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(apiUrl, content);
                    var responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Usuario agregado con éxito");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario: " + responseString);
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
