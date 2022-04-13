using System;
using System.Collections.Generic;

namespace Bolillero.Core
{
    public class Aleatorio : IAzar
    {
        public Random r = new Random();
        public byte SacarBolilla(List<byte> bolillas)
        {
            byte cantidad = bolillas.Count;
            var indice = r.NextBytes(0,cantidad);
            return bolillas[indice];
        }
    }
}