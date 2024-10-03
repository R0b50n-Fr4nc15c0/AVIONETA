using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIONETA
{
    public class Plane:Maquina, Voador
    {
        public void decolar() { Console.Write("Avião decolando:XXXXXXIIIIIUUUMMMMMMMMMM!"); }
        public void voar() { Console.Write("Avião voando:ZZZUUUMMMMM!"); }
        public void pousar() { Console.Write("Avião pousando:EEIIUUUMMMM! RMMM! RRMM! RMM!(SOM DAS RODINHAS DO AVIÃO ENCOSTANDO NA PISTA)"); }

        public void ligar() { Console.WriteLine("Ligando...."); }
        public void EmitirAlerta() { Console.WriteLine("Emitindo alerta...."); }
        public void desligar() { Console.WriteLine("Desligando...."); }

    }

}    
