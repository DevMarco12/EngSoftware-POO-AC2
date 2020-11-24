using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Pato_Borracha : Pato
    {
        public Pato_Borracha()
        {
            this.setComportamento(new Nao_Voa());
        }

        public override string Mostrar()
        {
            return "Olá, eu sou o de Borracha.";
        }
    }
}
