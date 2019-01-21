using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraCore.Models
{
    public class Lancamentos
    {
        public int Id { set; get; }
        public decimal Valor { private set; get; }

        protected Lancamentos()
        { }

        public Lancamentos(decimal valor)
        {
            this.Valor = valor;
        }

    }
}
