using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIONETA
{
    public class Pterodactilo:Dino, Voador
    {
        public void decolar() { Console.WriteLine("Tem que pegar uma boa distancia pra pegar velocidade para levantar voó."); }
        public void voar() { Console.WriteLine("Voando alto!"); }
        public void pousar() { Console.WriteLine("E pousando..."); }
    }
}
