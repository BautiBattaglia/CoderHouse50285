using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clase7
{
    public partial class DiccionariosListas : Form
    {
        // Define el diccionario como una variable de clase
        Dictionary<string, string> ciudadesXPaises = new Dictionary<string, string>();

        public DiccionariosListas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Forma de inicializar un array N1
            string[] razasDePerrosArray = new string[5];
            razasDePerrosArray[0] = "Dalmata";
            razasDePerrosArray[1] = "Golden";
            razasDePerrosArray[2] = "Caniche";
            razasDePerrosArray[3] = "Pequines";
            razasDePerrosArray[4] = "Salchicha";

            //Agregamos a la lista los elementos del array
            for (int i = 0; i < razasDePerrosArray.Length; i++)
            {
                lstRazasDePerros.Items.Add(razasDePerrosArray[i]);
            }

            //Forma de inicializar un array N2
            string[] razasDePerrosArrayInicializado = { "Dogo", "Doberman", "Bulldog", "Rottweiler" };

            //Mostramos por pantalla el array 2
            Console.WriteLine("Las razas de perros con array inicializado son:");
            for (int i = 0; i < razasDePerrosArrayInicializado.Length; i++)
            {
                Console.WriteLine(razasDePerrosArrayInicializado[i]);
            }

            //Agregar elementos al diccionario
            ciudadesXPaises.Add("Santiago", "Chile");
            ciudadesXPaises.Add("Bogota", "Colombia");
            ciudadesXPaises.Add("Buenos Aires", "Argentina");
            ciudadesXPaises.Add("Brasilia", "Brasil");

            //Foreach para recorrer cada elemento del diccionario
            foreach (KeyValuePair<string, string> ciudad in ciudadesXPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Funciones a partir de un botón para tratamiento de un diccionario

            // Eliminar un elemento del diccionario
            ciudadesXPaises.Remove("Santiago");

            // Limpiamos el listbox
            lstCiudadesPais.Items.Clear();

            //Mostramos el diccionario con sus modificaciones
            foreach (KeyValuePair<string, string> ciudad in ciudadesXPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Funciones a partir de un botón para tratamiento de un diccionario

            // Modificar  un elemento del diccionario
            ciudadesXPaises["Bogota"] = "Peru"; //item

            // Limpiamos el listbox
            lstCiudadesPais.Items.Clear();

            //Mostramos el diccionario con sus modificaciones
            foreach (KeyValuePair<string, string> ciudad in ciudadesXPaises)
            {
                lstCiudadesPais.Items.Add(ciudad.Key + " - " + ciudad.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Funciones a partir de un botón para tratamiento de un diccionario

            string pais;
            if (ciudadesXPaises.ContainsKey("Brasilia"))
            {
                ciudadesXPaises.TryGetValue("Brasilia", out pais);
                //Mostramos un mensaje al usuario
                MessageBox.Show("El pais donde pertenece la ciudad de Brasilia es: " + pais);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ciudadesXPaises.Clear();
            //Limpiamos el listbox
            lstCiudadesPais.Items.Clear();
            MessageBox.Show("Se limpio el contenido del diccionario.");
        }
    }
}
