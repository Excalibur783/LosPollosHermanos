using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosHermanos
{
    public partial class VentanaRealizarVenta : Form
    {
        public VentanaRealizarVenta()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidad = (int) nudCantidad.Value;
            int precio = cantidad * 25;
            lblPrecio.Text += precio.ToString() + '€';
            lblPrecio.Visible = true;
        }
    }
}
