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
    public partial class VentanaActualizarEmpleado : Form
    {
        private Empleado empleadoSeleccionado;

        public VentanaActualizarEmpleado()
        {
            InitializeComponent();
            actualizarListaEmpleados();
            ControlBox = false;
        }

        private void actualizarListaEmpleados()
        {
            cmbIdEmpleado.Items.Clear();

            foreach (Empleado empleado in Program.empleados)
                cmbIdEmpleado.Items.Add(empleado.getId());
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaMenu f2 = new VentanaMenu();
            f2.Show();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Program.empleados)
                if (empleado == empleadoSeleccionado)
                {
                    ConexionBaseDatos conexion = new ConexionBaseDatos();
                    conexion.Conectar();
                    conexion.actualizarEmpleado(empleado.getId(), txtNombre.Text, txtApellidos.Text, int.Parse(txtTelefono.Text), txtCorreo.Text);
                    conexion.Desconectar();

                    MessageBox.Show("SE HA MODIFICADO EL SOCIO CORRECTAMENTE");
                }
        }

        private void cmbIdEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            String idEmpleadoSeleccionado = cmbIdEmpleado.SelectedItem.ToString();

            foreach (Empleado empleado in Program.empleados)
                if (empleado.getId() == int.Parse(idEmpleadoSeleccionado))
                {
                    empleadoSeleccionado = empleado;
                    txtNombre.Text = empleadoSeleccionado.getNombre();
                    txtApellidos.Text = empleadoSeleccionado.getApellido();
                    txtTelefono.Text = empleadoSeleccionado.getNumTelefono().ToString();
                    txtCorreo.Text = empleadoSeleccionado.getCorreoElectronico();
                }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Program.empleados.Remove(empleadoSeleccionado);
            actualizarListaEmpleados();
            cmbIdEmpleado.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtTelefono.Text = String.Empty;
            txtCorreo.Text = String.Empty;

            ConexionBaseDatos conexion = new ConexionBaseDatos();
            conexion.Conectar();
            conexion.borrarEmpleado(empleadoSeleccionado.getId());
            conexion.Desconectar();

            MessageBox.Show("SE HA BORRADO EL SOCIO");
        }
    }
}
