﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    public class Nao_Voa : Padrao_Voaveis
    {
        public Nao_Voa()
        {

        }

        public String voar()
        {
            return "Esse pato não voa. Velocidade: " + getVelocidade();
        }

        public double getVelocidade()
        {
            return 0;
        }
    }
}
