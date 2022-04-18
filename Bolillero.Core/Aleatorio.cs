using System;
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Aleatorio : IAzar
    {
        public Random r = new Random();
       

        public byte SacarBollilla(List<byte> bolillas)
        {
            int cantidad = bolillas.Count();
            var indice = r.Next(0,cantidad);
            return bolillas[indice];
        }
    }
}