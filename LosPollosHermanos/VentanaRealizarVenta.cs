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
            ControlBox = false;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidad = (int) nudCantidad.Value;
            int precio = cantidad * 20000;
            lblPrecio.Text = "Precio: " + precio.ToString() + '€';
            lblPrecio.Visible = true;

            Program.gustavo.realizarVenta(txtIdCliente.Text, cantidad);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }
    }
}
