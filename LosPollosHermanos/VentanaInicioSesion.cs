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
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaMenu miForm2 = new VentanaMenu();
            String username = Program.gustavo.getNombre_usuario();
            String password = Program.gustavo.getPassword();
            if (textBox1.Text.Equals(username) && textBox2.Text.Equals(password))
            {
                miForm2.Show();
                ConexionBaseDatos conexion = new ConexionBaseDatos();
                conexion.Conectar();
                conexion.cargarDatos();
                this.Hide();
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
            }
            else
                MessageBox.Show("NOMBRE DE USUARIO O CONTRASEÑA INCORRECTOS");
            
        }
    }
}
