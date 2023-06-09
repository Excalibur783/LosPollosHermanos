using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

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

        private void button1_Click(object sender, EventArgs e)
        {
            int idEmpleado = int.Parse(txtIdEmpleado.Text);
            String nombre = txtNombre.Text;
            String apellidos = txtApellidos.Text;
            int telefono = int.Parse(txtTelefono.Text);
            String correo = txtCorreo.Text;

            txtIdEmpleado.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCorreo.Text = String.Empty;

            ConexionBaseDatos conexion = new ConexionBaseDatos();
            conexion.Conectar();
            conexion.altaEmpleado(idEmpleado, nombre, apellidos, telefono, correo);
            conexion.Desconectar();
        }
    }
}
