﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public class NotaFiscalDao : AcaoAposGerarNota
	{
		public void Executa(NotaFiscal nf)
		{
			Console.WriteLine("Salvando no banco de dados");
		}
	}
}
