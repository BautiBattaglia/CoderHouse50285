namespace DiccionarioAnidado
{
    public partial class DiccionarioAnidado : Form
    {

        //Diccionario anidado para EJEMPLO: PET SHOP
        Dictionary<string, Dictionary<string, double>> catalogoPetShop = new Dictionary<string, Dictionary<string, double>>();
        


        public DiccionarioAnidado()
        {
            InitializeComponent();
        }

        private void DiccionarioAnidado_Load(object sender, EventArgs e)
        {
            //Add values to dictionary
            catalogoPetShop.Add("Alimentos para Gatos Adultos", new Dictionary<string, double> 
            { { "Cat Chow", 900},
            { "Wiskas", 1200 },
            {"Pedigres", 1800 }});

            catalogoPetShop.Add("Alimentos para Gatos Cachorros", new Dictionary<string, double>
            { { "Cat Chow", 650},
            { "Wiskas", 850 },
            {"Pedigres", 1250 }});

            catalogoPetShop.Add("Alimentos para Perros Adultos", new Dictionary<string, double>
            { { "Dog Chow", 700},
            { "Proplan", 1100 },
            {"Pedigres", 1900 }});

            catalogoPetShop.Add("Alimentos para Perros Cachorros", new Dictionary<string, double>
            { { "Dog Chow", 450},
            { "Proplan", 550 },
            {"Pedigres", 1550 }});


            //Traverse nested dictionary and complete the list
            lstAlimentosPet.Items.Add("Seccion\t\t\t\tProducto\t\tPrecio");
            foreach(KeyValuePair<string, Dictionary<string,double>> seccion in catalogoPetShop)
            {
                lstAlimentosPet.Items.Add(seccion.Key);
                foreach(KeyValuePair<string, double> precioValor in seccion.Value)
                {
                    lstAlimentosPet.Items.Add("\t\t\t\t" + precioValor.Key + "\t\t" + precioValor.Value);
                }
            }


        }
    }
}
