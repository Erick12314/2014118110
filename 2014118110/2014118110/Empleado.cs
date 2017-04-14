using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Empleado
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int DNI { get; set; }
        public int Edad { get; set; }

        public Empleado(String nombre, String apellidos, int dni, int edad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            DNI = dni;
            Edad = edad;
        }

    }
}
