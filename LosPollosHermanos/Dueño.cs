using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosPollosHermanos
{
    public class Dueño
    {
        public string nombre_usuario
        {
            get => default;
            set
            {
            }
        }

        public string password
        {
            get => default;
            set
            {
            }
        }

        public int dinero
        {
            get => default;
            set
            {
            }
        }

        public int stock
        {
            get => default;
            set
            {
            }
        }

        public void realizarPedido(int cantidad)
        {
            int precio_kilo = 15000;

            if (cantidad <= stock)
            {
                stock += cantidad;
                dinero -= (precio_kilo * cantidad);
            }
        }

        public void realizarVenta(string id_cliente, int cantidad)
        {
            int precio_venta = 20000;

            if (cantidad <= stock)
            {
                stock -= cantidad;
                dinero += (precio_venta * cantidad);
            }
            
        }

        public string consultarBanco()
        {
            return "El saldo disponible en su cuenta es de " + dinero;
        }
    }
}