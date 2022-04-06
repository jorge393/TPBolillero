using System;
using System.Collections.Generic;
using System.Linq;

namespace Bolillero.Core{
public class Bolillero 
{
    public List<byte> Adentro{get;set;}
    public List<byte> Afuera{get;set;}
    private IAzar azar;

    public Bolillero()
    {
        Adentro = new List<byte>();
        Afuera = new List<byte>();
    }
    public Bolillero(byte bolilla)
    {
        Adentro = bolilla;
    }
    private void CrearBolillas(byte num)
    {
        Adentro = new List<byte>();
        Afuera = new List<byte>();
        for (byte i = 0; i <= num; i++)
        {
            Adentro.Add(i);
        }
    }
    public Reingresar()
    {
        Afuera.Count();
        Adentro.AddRange(Afuera);
        Afuera.Clear;

    }
    public byte SacarBolilla()
    {

    }
    public bool Jugar(List<byte> num)
    {

    }
    public long JugarN(List<byte> num)
    {
        
    }
}
}