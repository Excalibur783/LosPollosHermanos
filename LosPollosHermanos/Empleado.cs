using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace LosPollosHermanos
{
    public class Empleado : Persona
    {
        private int numTelefono;
        private String correoElectronico;

        public Empleado(int id, String nombre, String apellido, int numTelefono, String correo): base(id, nombre, apellido)
        {
            //Gestionando creacion de objetos tipo empleado, para acceso inicio sesion.
            setNumTelefono(numTelefono);
            setCorreoElectronico(correoElectronico);
        }

        public void setNumTelefono(int numTelefono)
        {
            this.numTelefono = numTelefono;
        }
        public int getNumTelefono() 
        {  
            return this.numTelefono; 
        }
        public String getCorreoElectronico()
        {
            return this.correoElectronico;
        }
        public void setCorreoElectronico(String correoElectronico)
        {
            this.correoElectronico = correoElectronico;
        }
    }
}