using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pedido
{
	public class Pedido
	{
		private ICalculadorDeFrete _calculadorDeFrete;

		public Pedido(ICalculadorDeFrete calculadorDeFrete)
		{
			_calculadorDeFrete = calculadorDeFrete;
		}

		public decimal CalcularFrete()
		{
			// delegando o cálculo do frete para o objeto Strategy configurado
			return _calculadorDeFrete.CalcularFretePara(this);
		}


	}
}
