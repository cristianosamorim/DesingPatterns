using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class Finalizado : EstadoDeUmOrcamento
	{
		public void AplicaDescontoExtra(Orcamento orcamento)
		{
			throw new Exception("Orcamentos finalizados não recebem desconto extra.");
		}

		public void Aprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento já está finalizado.");
		}

		public void Reprova(Orcamento orcamento)
		{
			throw new Exception("Orcamento já está em aprovado, não pode ser Finalizado.");
		}

		public void Finaliza(Orcamento orcamento)
		{
			orcamento.EstadoAtual = new Finalizado();
		}
	}
}
