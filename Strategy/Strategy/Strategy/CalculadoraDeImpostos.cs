﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
	public class CalculadoraDeImpostos
	{
		public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
		{
			double icms = imposto.Calcula(orcamento);
			Console.WriteLine(icms);
		}
	}
}
