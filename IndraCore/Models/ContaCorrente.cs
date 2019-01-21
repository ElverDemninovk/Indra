using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraCore.Models
{
    public class ContaCorrente
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public List<Lancamentos> Lancamentos { get; set; }

        public ContaCorrente()
        {
            this.Lancamentos = new List<Lancamentos>();
        }

        public async void Credito(decimal _valor)
        {
            this.Lancamentos.Add(new Models.Lancamentos(_valor));            
        }

        public async void Debito(decimal _valor)
        {
            this.Lancamentos.Add(new Models.Lancamentos(-_valor));
        }
    }
}
