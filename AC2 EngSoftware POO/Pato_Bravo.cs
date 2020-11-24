using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Pato_Bravo : Pato, Padrao_Grasnar // Herda da classe "Pato" e tem como implemento "Padrao_Grasnar"
    {
        public Pato_Bravo()
        {
            setComportamento(new Voaveis_Asa());
        }

        public String grasnar()
        {
            return "Quack-quack. Grrrrrr.";
        }

        public override string Mostrar()
        {
            return "Eu sou o Pato Bravo.";
        }
    }
}
