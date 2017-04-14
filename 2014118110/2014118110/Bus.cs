using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2014118110
{
    public class Bus
    {
        public String Placa { get; set; }
        public String SerieMotor { get; set; }
        private int capacidad = 45;

        public int Capacidad
        {
            get
            {
                return capacidad;
            }
        }

        public Bus(int pasajeros, Tripulacion tripulacion)
        {
            Placa = String.Empty;
            SerieMotor = String.Empty;
            //capacidad máxima de pasajeros 45
            int calculo = capacidad - (pasajeros + tripulacion.Cantidad);
            if (calculo < 0)
            {
                Console.WriteLine("Capacidad del bus excedida");
            }
            else
            {
                capacidad = calculo;
            }
        }
    }
}
