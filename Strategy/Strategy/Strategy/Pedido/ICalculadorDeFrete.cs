using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Pedido
{
	public interface ICalculadorDeFrete
	{
		decimal CalcularFretePara(Pedido pedido);
	}
}
