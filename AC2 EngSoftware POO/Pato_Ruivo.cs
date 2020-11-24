using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Pato_Ruivo : Pato, Padrao_Grasnar // Classe concreta 
    {
        public Pato_Ruivo() // Construtor
        {
            setComportamento(new Voaveis_Asa());
        }

        public String grasnar() // Método concreto
        {
            return "Quack-Quack";
        }

        public override string Mostrar() // Polimorfismo
        {
            return "Eu sou o Pato Ruivo.";
        }
    }
}
