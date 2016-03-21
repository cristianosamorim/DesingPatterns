using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class Cofins : Imposto
	{
		public Cofins(Imposto outroImposto) : base(outroImposto) { }
		public Cofins() : base() { }
		
		public override double Calcula(Orcamento orcamento)
		{
			return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
		}
	}
}
