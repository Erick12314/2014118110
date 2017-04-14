using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Encomienda : Servicio
    {
        public LugarViaje Origen { get; set; }
        public LugarViaje Destino { get; set; }
        public String AsuntoEncomienda { get; set; }
        public String NombreDestinatario { get; set; }
    }
}
