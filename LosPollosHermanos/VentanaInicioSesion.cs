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
    public partial class VentanaInicioSesion : Form
    {
        public VentanaInicioSesion()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.SetVisibleCore(false);

            VentanaMenu miForm2 = new VentanaMenu();
            miForm2.Show();
        }
    }
}
