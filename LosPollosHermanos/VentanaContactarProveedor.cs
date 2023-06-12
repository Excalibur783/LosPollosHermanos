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
    public partial class VentanaContactarProveedor : Form
    {
        public VentanaContactarProveedor()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.gustavo.realizarPedido((int) numericUpDown1.Value);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }
    }
}
