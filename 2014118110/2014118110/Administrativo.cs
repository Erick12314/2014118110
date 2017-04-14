using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Administrativo : Empleado
    {
        public int Sueldo { get; set; }
        public String Cargo { get; set; }
        public Administrativo(String nombre, String apellidos, int dni, int edad) : base(nombre, apellidos, dni, edad)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.DNI = dni;
            this.Edad = edad;
            Sueldo = 0;
            Cargo = String.Empty;
        }
    }
}
