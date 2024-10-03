using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIONETA
{
    public class Dino:ISer_vivo
    {
        public void respirar() { Console.Write("Necesidade de respirar..."); }
        public void comer() { Console.Write("Necessidade de si alimentar..."); }
        public void beber() { Console.Write("Necessidade de si idratar"); }
        public void NF() { Console.Write("NF = Necessidades Fisiologicas"); }
        public void reproduzir() { Console.Write("Capacidade de si mutiplicar"); }
        public void Dead() { Console.Write("O final do ciclo de vida dos seres vivos"); }
    }
}
