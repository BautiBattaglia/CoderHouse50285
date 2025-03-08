using System;
using System.Net.Http;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class UsuarioFormEliminar : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private string apiUrl = "http://localhost:5000/api/Usuario";

        public UsuarioFormEliminar()
        {
            InitializeComponent();
        }

        private async void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var id = txtUsuarioID.Text;
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("Por favor, ingrese un ID de usuario válido.");
                return;
            }

            try
            {
                var response = await client.DeleteAsync($"{apiUrl}/{id}");
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Usuario eliminado exitosamente.");
                }
                else
                {
                    MessageBox.Show($"Error al eliminar el usuario: {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario: {ex.Message}");
            }
        }
    }
}
