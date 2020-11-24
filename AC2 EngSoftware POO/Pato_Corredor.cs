using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Pato_Corredor : Pato
    {
        private double velocidade;

        public Pato_Corredor()
        {
            velocidade = 500;
            this.setComportamento(new Corredores_Patas());
        }

        public override String mostrar()
        {
            return "Olá! Eu sou o pato corredor.";
        }

        public double GetVelocidade()
        {
            return "Esse pato está correndo com a velocidade" + velocidade;
        }
    }
}
