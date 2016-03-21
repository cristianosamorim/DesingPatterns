using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class NotaFiscal
	{
		private string RazaoSocial1;
		private string Cnpj1;
		private DateTime Data;
		private IList<ItemDaNota> todosItens;
		private string Observacoes1;

		public NotaFiscal(string RazaoSocial1, string Cnpj1, DateTime Data, IList<ItemDaNota> todosItens, string Observacoes1)
		{
			// TODO: Complete member initialization
			this.RazaoSocial1 = RazaoSocial1;
			this.Cnpj1 = Cnpj1;
			this.Data = Data;
			this.todosItens = todosItens;
			this.Observacoes1 = Observacoes1;
		}
		public String RazaoSocial { get; set; }
		public String Cnpj { get; set; }
		public DateTime DataDeEmissao { get; set; }
		public double ValorBruto { get; set; }
		public double Impostos { get; set; }
		public IList<ItemDaNota> Itens { get; set; }
		public String Observacoes { get; set; }
	}
}
