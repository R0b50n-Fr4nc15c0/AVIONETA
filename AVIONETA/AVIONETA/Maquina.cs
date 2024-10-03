using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVIONETA
{
    public interface Maquina
    {
        public void ligar();
        public void EmitirAlerta();
        public void desligar();
    }
}
