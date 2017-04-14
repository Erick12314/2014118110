using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Transporte : Servicio
    {
        public LugarViaje Destino { get; set; }
        public LugarViaje Origen { get; set; }
    }
}
