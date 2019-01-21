using IndraCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraCore.ViewModels
{
    public class DebitosModel
    {
        public ContaCorrente Origem { set; get; }
        public ContaCorrente Destino { set; get; }
        public Decimal Valor { set; get; }
    }
}
