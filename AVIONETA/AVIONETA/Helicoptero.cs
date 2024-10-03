using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIONETA
{
    public class Helicoptero:IPairador, Voador, Maquina

    {
        public void ligar() { Console.Write("Ligando..."); }
        public void EmitirAlerta() { Console.Write("Alerta:PEEM! PEEM! PEEM! PEEM! ..."); }
        public void desligar() { Console.Write("Desligando..."); }

        public void PararEmPlenoAr() { Console.Write("Um dos poucos veiculos que pode pairar no ar."); }

        public void decolar() { Console.Write("Decolando:vrum! vrum! vrum! vrum! vrum! vrum! ..."); }
        public void voar() { Console.Write("Voando:VROM! VROM! VROM! VROM! VROM! VROM! VROM! ..."); }
        public void pousar() { Console.Write("vrum! vrum! vrum! vrum! vrum! vrum!..."); }
    }
}
