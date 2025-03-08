namespace _ALaCarta
{
    public partial class frmALaCarta : Form
    {
        //Diccionario anidado para EJEMPLO: A LA CARTA
        Dictionary<string, Dictionary<string, double>> cartaRestautante = new Dictionary<string, Dictionary<string, double>>();

        //Necesito agrupar por Tipo, Nombre y Precio


        public frmALaCarta()
        {
            InitializeComponent();
        }

        private void frmALaCarta_Load(object sender, EventArgs e)
        {
            //Add values to dictionary
            cartaRestautante.Add("Bebidas alcohólicas", new Dictionary<string, double>
            { { "Cosecha", 1900},
            { "Chandon", 2500 },
            {"Quilmas", 920 }});
            cartaRestautante.Add("Bebidas sin alcohol", new Dictionary<string, double>
            { { "Coca Cola", 1200},
            { "Sprite", 1200 },
            {"Agua", 800 }});
            cartaRestautante.Add("Entradas", new Dictionary<string, double>
            { { "Papas", 3500},
            { "Huevos", 1500 },
            {"Canastitas", 1200 }});
            cartaRestautante.Add("Plato Principal", new Dictionary<string, double>
            { { "Milanesas", 7200},
            { "Entraña", 9300 },
            {"Pastel", 5600 }});
            cartaRestautante.Add("Postre", new Dictionary<string, double>
            { { "Helado", 2300},
            { "Bombon", 1800 },
            {"Flan", 1900 }});
            

            //Traverse nested dictionary and complete the list
            lstCartaRestaurant.Items.Add("Seccion\t\t\t\tProducto\t\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in cartaRestautante)
            {
                lstCartaRestaurant.Items.Add(seccion.Key.ToUpper());
                foreach (KeyValuePair<string, double> precioValor in seccion.Value)
                {
                    lstCartaRestaurant.Items.Add("\t\t\t\t" + precioValor.Key.ToUpper() + "\t\t\t$" + precioValor.Value);
                }
            }
            

        }
    }
}
