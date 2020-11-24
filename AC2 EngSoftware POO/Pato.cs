using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public abstract class Pato // Classe abstrata
    {
        protected Padrao_Voaveis comportamento_pato; // Composição

        public abstract String Mostrar(); // Método abstrato

        public String nadar()
        {
            return "Pato nadando...";
        }

        public String correr()
        {
            return "Pato correndo...";
        }

        public void setComportamento(Padrao_Voaveis padrao)
        {
            comportamento_pato = padrao;
        }

        public String comportamentoPato()
        {
            return comportamento_pato.voar();
        }
    }
}
