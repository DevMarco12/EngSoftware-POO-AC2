using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
	public class Corredores_Patas : Padrao_Corrida
	{
		private double velocidade;

		public void Corredores()
		{
			velocidade = 1000;
		}

		public String correr()
		{
			return "Correndo igual uma Ferrari. Velocidade: " + getVelocidade();
		}

		public double getVelocidade()
		{
			return velocidade;
		}
	}
}
