using System.Diagnostics.Contracts;

namespace Matrices
{
    public partial class Form1 : Form
    {

        class Matriz
        {
            private int[,] matriz;
            private const int DIMENSION_FILA = 0;
            private const int DIMENSION_COLUMNA = 1;

            public Matriz(int filas, int columnas)
            {
                if (columnas > 0 && filas > 0)
                {
                    _matriz = new int[filas, columnas];
                }
                else
                {
                    new Matriz();
                }
            }

            public Matriz()
            {
                _matriz = new int[2,3]; //matriz por defecto
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
