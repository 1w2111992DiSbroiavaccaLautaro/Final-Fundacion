﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundacion.Resultados
{
    public class ResultadosApi
    {
        public int CodigoError { get; set; }
        public bool Ok { get; set; }
        public string Error { get; set; }
        public object Return { get; set; }
    }
}
