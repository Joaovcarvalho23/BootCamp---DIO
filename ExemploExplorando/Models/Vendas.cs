using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco, DateTime dataDaVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataDaVenda = dataDaVenda;
        }

        public int Id { get; set;}
        public string? Produto { get; set;}
        public decimal Preco { get; set;}
        public DateTime DataDaVenda { get; set;}
    }
}