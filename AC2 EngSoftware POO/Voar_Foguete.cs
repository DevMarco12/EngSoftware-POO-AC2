using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Voar_Foguete : Padrao_Voaveis
    {
        private double velocidade;

        public Voar_Foguete()
        {
            velocidade = 1000;
        }

        public String voar()
        {
            return "Vaoando como um foguete. Velocidade: " + getVelocidade();
        }

        public double getVelocidade()
        {
            return velocidade;
        }
    }
}
