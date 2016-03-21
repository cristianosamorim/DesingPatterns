using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	class Program
	{
		static void Main(string[] args)
		{
			CalculadorDescontos calculador = new CalculadorDescontos();
			
			Orcamento orcamento = new Orcamento(500);
			orcamento.AdicionaItem(new Item("Caneta", 250));
			orcamento.AdicionaItem(new Item("Lapis", 250));
			orcamento.AdicionaItem(new Item("Geladeira", 250));
			orcamento.AdicionaItem(new Item("Fogão", 250));
			orcamento.AdicionaItem(new Item("Borracha", 250));
			orcamento.AdicionaItem(new Item("Microndas", 250));

			var desconto = calculador.Calcula(orcamento);
            Console.WriteLine(desconto);

			Console.ReadKey();
		}
	}
}
