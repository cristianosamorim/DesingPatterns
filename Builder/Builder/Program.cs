using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			NotaFiscalBuilder criador = new NotaFiscalBuilder();
			criador.ParaEmpresa("Voonder Comercio Ltda.")
				   .ComCnpj("176.176.569.52")
				   .NaDataAtual()
				   .ComItem(new ItemDaNota("item 1", 100.0))
				   .ComItem(new ItemDaNota("item 2", 200.0))
				   .ComItem(new ItemDaNota("item 3", 300.0))
				   .ComObservacoes("Teste de desing pattern do Builder");

			var nf = criador.Constroi();
            Console.WriteLine(nf.ValorBruto);
			Console.WriteLine(nf.Impostos);

			Console.ReadKey();

		}
	}
}
