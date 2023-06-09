using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace LosPollosHermanos
{
    internal class ConexionBaseDatos
    {
        NpgsqlConnection con = new NpgsqlConnection("Server = localhost; User Id = postgres; Password = 123456; Database = LPH_ENTORNOS_BD");

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public void cargarDatos()
        {
            String queryEmpleados = "SELECT * FROM empleado;";
            NpgsqlCommand cmdEmpleados = new NpgsqlCommand(queryEmpleados, con);
            NpgsqlDataReader readerEmpleado = cmdEmpleados.ExecuteReader();

            while (readerEmpleado.Read())
            {
                int idEmpleado = readerEmpleado.GetInt32(0);
                String nombre = readerEmpleado.GetString(1);
                String apellidos = readerEmpleado.GetString(2);
                String correo = readerEmpleado.GetString(3);
                int telefono = readerEmpleado.GetInt32(4);

                Program.empleados.Add(new Empleado(idEmpleado, nombre, apellidos, telefono, correo));
            }

            readerEmpleado.Close();

            String queryClientes = "SELECT * FROM cliente;";
            NpgsqlCommand cmdCliente = new NpgsqlCommand(queryClientes, con);
            NpgsqlDataReader readerCliente = cmdCliente.ExecuteReader();

            while (readerCliente.Read())
            {
                int idCliente = readerCliente.GetInt32(0);
                String nombre = readerCliente.GetString(1);
                String apellidos = readerCliente.GetString(2);

                Program.clientes.Add(new Cliente(idCliente, nombre, apellidos));
            }

            readerCliente.Close();
        }

        public void altaEmpleado(int idEmpleado, String nombre, String apellidos, int telefono, String correo)
        {
            String query = "INSERT INTO empleado VALUES (" + idEmpleado + ", '" + nombre + "', '" + apellidos + "', '" + correo + "', " + telefono + ");";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("SE HA DADO DE ALTA EL EMPLEADO");
        }

        public void actualizarEmpleado(int idEmpleado, String nombre, String apellidos, int telefono, String correo)
        {
            String query = "UPDATE empleado SET nombre = '" + nombre + "', apellido = '" + apellidos + "', correoElectronico = '" + correo + "', numTelefono = " + telefono + " WHERE id = " + idEmpleado + ";";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("SE HA ACTUALIZADO EL EMPLEADO CORRECTAMENTE");
            MessageBox.Show("UPDATE empleado SET nombre = '" + nombre + "', apellido = '" + apellidos + "', correoElectronico = '" + correo + "', numTelefono = " + telefono + " WHERE id = " + idEmpleado + ";");
        }

        public void borrarEmpleado(int idEmpleado)
        {
            String query = "DELETE FROM empleado WHERE id = " + idEmpleado + ";";
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("SE HA BORRADO EL EMPLEADO CORRECTAMENTE");
        }

        public void altaCliente(int idCliente, String nombre, String apellidos)
        {
            String query = "INSERT INTO cliente VALUES (" + idCliente + ", '" + nombre + "', '" + apellidos + "');";

            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("SE HA DADO DE ALTA EL CLIENTE");
        }
    }
}
