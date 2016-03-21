using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class SemDesconto : Desconto
	{
		public Desconto Proximo { get; set; }

		public double Desconta(Orcamento orcamneto)
		{
			return 0;
		}
	}
}
