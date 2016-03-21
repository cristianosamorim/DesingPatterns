using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
	public class NotaFiscalBuilder
	{
		public String RazaoSocial { get; private set; }
		public String Cnpj { get; private set; }
		public String Observacoes { get; private set; }
		public DateTime Data { get; private set; }

		private double valorTotal;
		private double impostos;
		private IList<ItemDaNota> todosItens = new List<ItemDaNota>();

		public NotaFiscal Constroi()
		{
			return new NotaFiscal(RazaoSocial, Cnpj, Data, todosItens, Observacoes);
		}

		public NotaFiscalBuilder ParaEmpresa(String razaSocial)
		{
			this.RazaoSocial = razaSocial;
			return this;
		}

		public NotaFiscalBuilder ComObservacoes(String observacoes)
		{
			this.Observacoes = observacoes;
			return this;
		}

		public NotaFiscalBuilder NaDataAtual()
		{
			this.Data = DateTime.Now;
			return this;

		}

		public NotaFiscalBuilder ComCnpj(String cnpj)
		{
			this.Cnpj = cnpj;
			return this;
		}

		public NotaFiscalBuilder ComItem(ItemDaNota item)
		{
			todosItens.Add(item);
			valorTotal += item.Valor;
			impostos += item.Valor * 0.05;

			return this;
		}
	}
}
