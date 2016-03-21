using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	class Program
	{
		static void Main(string[] args)
		{
			//http://www.dofactory.com/
			Orcamento orcamento = new Orcamento(500.0);
			CalculadoraDeImpostos calculador = new CalculadoraDeImpostos();

			calculador.RealizaCalculo(orcamento, new ICMS());
			calculador.RealizaCalculo(orcamento, new ISS());

			Console.ReadKey();

			// alguma classe que utilize o Pedido
			// pedido criado com o cálculo de frete padrão
			//var pedido1 = new Pedido(new CalculadorDeFretePadrao());
			//var fretePadrao = pedido1.CalcularFrete();

			// pedido criado com o cálculo de frete expresso
			//var pedido2 = new Pedido(new CalculadorDeFreteExpresso());
			//var freteExpresso = pedido2.CalcularFrete();

		}
	}
}
