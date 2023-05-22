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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.SetVisibleCore(false);

            Form2 miForm2 = new Form2();
            miForm2.Show();
        }
    }
}
