using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public interface Desconto
	{
		double Desconta(Orcamento ocramento);
		Desconto Proximo { get; set; }
	}
}
