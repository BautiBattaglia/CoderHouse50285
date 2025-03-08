using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clase_8
{
    public partial class Listas : Form
    {
        public class Cliente
        {
            public string Nombre { get; set; }
            public long ID { get; set; }
            public string Direccion { get; set; }
            public short Edad { get; set; }

            public Cliente(string nombre, long id, string direccion, short edad)
            {
                this.Nombre = nombre;
                this.ID = id;
                this.Direccion = direccion;
                this.Edad = edad;
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Cliente cliente = (Cliente)obj;
                return ID == cliente.ID;
            }

            public override int GetHashCode()
            {
                return ID.GetHashCode();
            }
        }

        public class ListaMayores
        {
            private List<Cliente> _clientesMayores;

            public ListaMayores()
            {
                _clientesMayores = new List<Cliente>();
            }

            public void InsertarEnLista(Cliente[] clientes)
            {
                for (int i = 0; i < clientes.Length; i++)
                {
                    _clientesMayores.Add(new Cliente(clientes[i].Nombre, clientes[i].ID, clientes[i].Direccion, clientes[i].Edad));
                }
            }

            public bool Borrar(Cliente cliente)
            {
                if (!_clientesMayores.Contains(cliente))
                {
                    return false;
                }
                return _clientesMayores.Remove(cliente);
            }

            public int Buscar(Cliente cliente)
            {
                return _clientesMayores.IndexOf(cliente);
            }

            public bool Modificar(Cliente actual, Cliente nuevo)
            {
                int posicion = Buscar(actual);
                if (posicion < 0)
                {
                    return false;
                }
                _clientesMayores[posicion] = nuevo;
                return true;
            }

            public void LimpiarLista()
            {
                _clientesMayores.Clear();
            }

            public void Ordenar()
            {
                _clientesMayores.Sort((cliente1, cliente2) => cliente1.ID.CompareTo(cliente2.ID));
            }

            public List<Cliente> GetListaMayores()
            {
                return _clientesMayores;
            }
        }

        ListaMayores mayores;
        private DataGridView dgMayores;

        public Listas()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dgMayores = new DataGridView { Dock = DockStyle.Fill };
            this.Controls.Add(dgMayores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mayores = new ListaMayores();

            Cliente[] clientes = {
                new Cliente("Bautista Battaglia", 12345, "Jose Marti 2875", 22),
                new Cliente("Pablo Battaglia", 12346, "Jose Marti 2875", 42),
                new Cliente("Fernando Battaglia", 14345, "Jose Marti 2875", 52),
                new Cliente("Tobias Battaglia", 12355, "Jose Marti 2873", 20),
                new Cliente("Claudio Battaglia", 12145, "Jose Marti 2873", 62),
                new Cliente("Elias Battaglia", 12348, "Jose Marti 2871", 25),
                new Cliente("Esteban Battaglia", 12349, "Jose Marti 2871", 21)
            };

            mayores.InsertarEnLista(clientes);
            CargarMayores();
        }

        private void CargarMayores()
        {
            dgMayores.AutoGenerateColumns = true;
            dgMayores.DataSource = mayores.GetListaMayores();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente clienteNuevo = new Cliente("Laura Fernandez", 71621, "Rodriguez Peña 1845", 71);

            dgMayores.DataSource = null;

            mayores.Borrar(clienteNuevo);

            CargarMayores();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Cliente aModificar = new Cliente("Laura Gonzalez", 98927, "Av la Plata 1627", 62);
            Cliente clienteNuevo = new Cliente("Laura Fernandez", 26271, "Rodriguez Peña 912", 71);
            mayores.Modificar(aModificar, clienteNuevo);

            CargarMayores();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            mayores.Ordenar();
            CargarMayores();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgMayores.DataSource = null;
            dgMayores.Refresh();
            mayores.LimpiarLista();
        }
    }
}
