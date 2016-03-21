using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pedido
{
	public class CalculadorDeFreteExpresso : ICalculadorDeFrete
	{
		public decimal CalcularFretePara(Pedido pedido)
		{
			return 12;
		}
	}
}
