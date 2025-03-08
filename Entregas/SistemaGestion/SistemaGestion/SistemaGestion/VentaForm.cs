using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class VentaForm : Form
    {
        public VentaForm()
        {
            InitializeComponent();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            var ventaFormAgregar = new VentaFormAgregar();
            ventaFormAgregar.Show();
        }

        private void btnConsultarVenta_Click(object sender, EventArgs e)
        {
            var ventaFormBuscar = new VentaFormBuscar();
            ventaFormBuscar.Show();
        }
    }
}
