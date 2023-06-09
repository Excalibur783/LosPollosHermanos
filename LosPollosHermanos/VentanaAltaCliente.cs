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
    public partial class VentanaAltaCliente : Form
    {
        public VentanaAltaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idCliente = int.Parse(txtIdCliente.Text);
            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;

            ConexionBaseDatos conexion = new ConexionBaseDatos();
            conexion.Conectar();
            conexion.altaCliente(idCliente, nombre, apellidos);
            conexion.Desconectar();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }
    }
}
