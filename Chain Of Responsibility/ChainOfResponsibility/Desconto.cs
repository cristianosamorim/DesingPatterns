using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
	public interface Desconto
	{
		double Desconta(Orcamento ocramento);
		Desconto Proximo { get; set; }
	}
}
