using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Tripulacion : Empleado
    {
        public TipoTripulacion TipoTripulacion { get; set; }
        public int Cantidad { get; set; }

        public Tripulacion(String nombre, String apellidos, int dni, int edad, int cantidad) : base(nombre, apellidos, dni, edad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.DNI = dni;
            this.Edad = edad;
            this.Cantidad = cantidad;
        }
    }
}
