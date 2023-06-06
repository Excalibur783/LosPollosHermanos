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
    public partial class VentanaMenu : Form
    {
        public VentanaMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaAltaEmpleado myForm3 = new VentanaAltaEmpleado();
            myForm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaContactarProveedor myForm5 = new VentanaContactarProveedor();
            myForm5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaAltaCliente myForm1 = new VentanaAltaCliente();
            myForm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaBanco banco = new VentanaBanco();
            banco.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaRealizarVenta rv = new VentanaRealizarVenta();
            rv.Show();
        }
    }
}
