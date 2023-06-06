using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LosPollosHermanos
{
    public class Persona
    {
        private int id;
        private String nombre;
        private String apellido;
        public Persona(int id, String nombre, String apellido) 
        {
            setId(id);
            setNombre(nombre);
            setApellido(apellido);
        }    
       
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }
        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }
        public String getApellido()
        {
            return this.apellido;
        }


    }
}