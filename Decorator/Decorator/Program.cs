using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Imposto iss = new ISS(new ICMS(new Cofins()));
			Orcamento orcamento = new Orcamento(100);

			double valor = iss.Calcula(orcamento);
			
			Console.WriteLine(valor);
			Console.ReadKey();
		}
	}
}
