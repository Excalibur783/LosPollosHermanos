using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LosPollosHermanos
{
    public class Dueño
    {
        private string nombre_usuario;

        private string password;

        private int dinero;

        private int stock;

        public Dueño() 
        {
            nombre_usuario = "GustavoFring";
            password = "password";
            dinero = 100000;
            stock = 0;
        }

        public string getNombre_usuario() { return nombre_usuario; }
        public string getPassword() { return password;}
        public int getDinero() {  return dinero;}
        public int getStock() {  return stock;}

        public void setNombre_usuario(string nombre_usuario)
        {
            this.nombre_usuario = nombre_usuario;
        }
        public void setPassword(string password) 
        {  
            this.password = password;
        } 
        public void setDinero(int dinero)
        {
            this.dinero = dinero;
        }
        public void setStock(int stock)
        {
            this.stock = stock;
        }



        public void realizarPedido(int cantidad)
        {
            int precio_kilo = 15000;

            if (getDinero() >= cantidad * precio_kilo)
            {
                setStock(getStock() + cantidad);
                setDinero(getDinero() - (precio_kilo * cantidad));
                MessageBox.Show("PEDIDO REALIZADO");
            }
            else
                MessageBox.Show("SALDO INSUFICIENTE");
        }

        public void realizarVenta(string id_cliente, int cantidad)
        {
            int precio_venta = 20000;

            if (cantidad <= getStock())
            {
                setStock(getStock() - cantidad);
                setDinero(getDinero() + (precio_venta * cantidad));
                MessageBox.Show("VENTA REALIZADA");
            }
            else
                MessageBox.Show("NO HAY SUFICIENTE STOCK. EL STOCK ACTUAL ES: "+getStock());
            
        }

        public string consultarBanco()
        {
            return "SALDO DISPONIBLE: " + getDinero() +"$";
        }
    }
}