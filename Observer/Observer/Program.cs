using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			NotaFiscalBuilder criador = new NotaFiscalBuilder();
			criador.ParaEmpresa("Voonder")
				   .ComCnpj("176.176.569.52")
				   .ComItem(new ItemDaNota("item 1", 100.0))
				   .ComItem(new ItemDaNota("item 2", 200.0))
				   .NaDataAtual()
				   .ComObservacoes("Teste de desing pattern do Builder");

			criador.AdicionaAcao(new EnviadorDeEmail());
			criador.AdicionaAcao(new EnviadorDeSms());
			criador.AdicionaAcao(new NotaFiscalDao());

			NotaFiscal nf = criador.Constroi();
			Console.WriteLine(nf.ValorBruto);
			Console.WriteLine(nf.Impostos);

			Console.ReadKey();
		}
	}
}
