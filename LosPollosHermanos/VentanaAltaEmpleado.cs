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
    public partial class VentanaAltaEmpleado : Form
    {
        public VentanaAltaEmpleado()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaRealizarVenta ventanaRealizarVenta = new VentanaRealizarVenta();
            ventanaRealizarVenta.Show();
        }
    }
}
