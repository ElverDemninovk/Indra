using IndraCore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace IndraCore.Controllers
{
    [Route("api/[controller]")]
    public class Debitos : Controller
    {

        Mycontext fakeContext;

        public Debitos()
        {
            //No construtor teriamos um ID com o contexto ou podemos criar um classe bunisses para fazer este debito 
            //e varias outras regras de negocios. 

            // estou estanciando mais como iria vim pelo ID so setaria o contexto
            fakeContext = new Mycontext();

        }

        // POST api/<controller>
        [HttpPost]
        public async void Post([FromBody] DebitosModel origem)
        {
            //Aqui tendo o Contexto no contrutor pegaria o buscaria cadac conta corrente para fazer os lancamentos.
            //Estou fazendo syncrono pq estou usando um fake de contexto se fosse usar mesmo o contexto real usuaria assim.
            //var ContaOrigem = await fakeContext.ContaCorrente.Where(x => x.Id == origem.Origem.Id).SingleOrDefaultAsync();
            var ContaOrigem = fakeContext.ContaCorrente.Where(x => x.Id == origem.Origem.Id).SingleOrDefault();
            var ContaDestino = fakeContext.ContaCorrente.Where(x => x.Id == origem.Destino.Id).SingleOrDefault();

            if (ContaOrigem == null || ContaDestino == null)
                NotFound();
            else
            {
                ContaOrigem.Debito(origem.Valor);
                ContaDestino.Credito(origem.Valor);

                Ok();
            }            
        }
    }
}
