using System;
using System.Collections.Generic;
using System.Linq;

namespace Bolillero.Core
{
    public class Bolillero
    {
        public List<byte> Adentro { get; set; }
        public List<byte> Afuera { get; set; }
        private IAzar azar;
        Aleatorio aleatorio;

        public Bolillero()
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
        }
        public Bolillero(byte bolilla) => CrearBolillas(bolilla);
        private void CrearBolillas(byte num)
        {
            Adentro = new List<byte>();
            Afuera = new List<byte>();
            for (byte i = 0; i <= num; i++)
            {
                Adentro.Add(i);
            }
        }
        public void Reingresar()
        {
            Adentro.AddRange(Afuera);
            Afuera.Clear;
        }
        public byte SacarBolilla()
        {
            var bolilla = aleatorio.SacarBolilla(Adentro);
            Adentro.Remove(bolilla);
            Afuera.Add(bolilla);
            return bolilla;
        }
        public bool Jugar(List<byte> num)
        {
            
        }
        public long JugarN(List<byte> num)
        {

        }
    }
}