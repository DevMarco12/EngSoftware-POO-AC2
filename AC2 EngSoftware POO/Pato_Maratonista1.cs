using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
	public class Pato_Maratonista : Pato
	{
		private double velocidade;

		public Pato_Maratonista()
		{
			velocidade = 1000;
			this.setComportamento(new Nao_Voa());
		}

		public override String Mostrar()
		{
			return "Olá! Eu sou o pato mais veloz da terra, também conhecido como maratornista.";
		}

		public String GetVelocidade()
		{
			return "Esse pato está correndo com a velocidade" + velocidade;
		}
	}
}
