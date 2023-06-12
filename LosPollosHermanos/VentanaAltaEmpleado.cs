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
using Npgsql;

namespace LosPollosHermanos
{
    public partial class VentanaAltaEmpleado : Form
    {
        public VentanaAltaEmpleado()
        {
            InitializeComponent();
            ControlBox = false;
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
            int idEmpleado = 0, telefono = 0;
            String nombre = String.Empty, apellidos = String.Empty, correo = String.Empty;

            bool formCorrecto = true;
            Regex regexId = new Regex("^[0-9]+$");
            Regex regexNombre = new Regex("^[a-zA-Z]+$");
            Regex regexApellidos = new Regex("^[a-zA-Z]+$");
            Regex regexTelefono = new Regex("^[0-9]{9,12}$");
            Regex regexEmail = new Regex("^[a-z]+[@][a-z]+[.][a-z]{2,3}$");
            errorProvider1.Clear();

            if (!regexId.IsMatch(txtIdEmpleado.Text))
            {
                errorProvider1.SetError(txtIdEmpleado, "No es válido ese formato");
                formCorrecto = false;
            } else
                idEmpleado = int.Parse(txtIdEmpleado.Text);

            if (!regexNombre.IsMatch(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "No es válido ese formato");
                formCorrecto = false;
            } else
                nombre = txtNombre.Text;

            if (!regexApellidos.IsMatch(txtApellidos.Text))
            {
                errorProvider1.SetError(txtApellidos, "No es válido ese formato");
                formCorrecto = false;
            } else
                apellidos = txtApellidos.Text;

            if (!regexTelefono.IsMatch(txtTelefono.Text))
            {
                errorProvider1.SetError(txtTelefono, "No es válido ese formato");
                formCorrecto = false;
            } else
                telefono = int.Parse(txtTelefono.Text);

            if (!regexEmail.IsMatch(txtCorreo.Text))
            {
                errorProvider1.SetError(txtCorreo, "No es válido ese formato");
                formCorrecto = false;
            }
            else
                correo = txtCorreo.Text;

            if (formCorrecto)
            {
                ConexionBaseDatos conexion = new ConexionBaseDatos();
                conexion.Conectar();
                conexion.altaEmpleado(idEmpleado, nombre, apellidos, telefono, correo);
                conexion.Desconectar();

                txtIdEmpleado.Text = String.Empty;
                txtNombre.Text = String.Empty;
                txtApellidos.Text = String.Empty;
                txtTelefono.Text = String.Empty;
                txtCorreo.Text = String.Empty;
            }
        }
    }
}
