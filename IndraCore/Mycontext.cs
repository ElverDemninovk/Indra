using IndraCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndraCore
{
    public class Mycontext
    {
        //Contexto fake so para mostrar como seria coma base de dados.

        public List<ContaCorrente> ContaCorrente { get; set; }


        public Mycontext()
        {
            ContaCorrente = new List<ContaCorrente>();
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 1, UserId = 1 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 2, UserId = 2 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 3, UserId = 3 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 4, UserId = 4 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 5, UserId = 5 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 6, UserId = 6 });
            ContaCorrente.Add(new Models.ContaCorrente() { Id = 7, UserId = 7 });
        }
    }
}
