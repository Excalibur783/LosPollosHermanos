using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosPollosHermanos
{
    public partial class VentanaAltaCliente : Form
    {
        public VentanaAltaCliente()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool formCorrecto = true;
            int idCliente = 0;
            String nombre = String.Empty, apellidos = String.Empty;

            Regex regexId = new Regex("^[0-9]+$");
            Regex regexNombre = new Regex("^[a-zA-Z]+$");
            Regex regexApellidos = new Regex("^[a-zA-Z]+$");
            errorProvider1.Clear();



            if (!regexId.IsMatch(txtIdCliente.Text))
            {
                errorProvider1.SetError(txtIdCliente, "No es válido ese formato");
                formCorrecto = false;
            }
            else
                idCliente = int.Parse(txtIdCliente.Text);

            if (!regexNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "No es válido ese formato");
                formCorrecto = false;
            }
            else
                nombre = txtNombre.Text;

            if (!regexApellidos.IsMatch(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "No es válido ese formato");
                formCorrecto = false;
            } else
            {
                apellidos = txtApellidos.Text;
            }

            if (formCorrecto)
            {
                ConexionBaseDatos conexion = new ConexionBaseDatos();
                conexion.Conectar();
                conexion.altaCliente(idCliente, nombre, apellidos);
                conexion.Desconectar();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }
    }
}
