﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
	public interface AcaoAposGerarNota
	{
		void Executa(NotaFiscal nf);
	}
}
