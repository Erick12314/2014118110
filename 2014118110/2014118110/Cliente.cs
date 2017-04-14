using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Cliente
    {
        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public int DNI { get; set; }

        public Cliente()
        {
            Nombre = String.Empty;
            Apellidos = String.Empty;
            DNI = 0;
        }
    }
}
