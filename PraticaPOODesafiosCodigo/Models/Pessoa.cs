using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaPOODesafiosCodigo.Models
{
    public class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }


            public Pessoa(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public string GetNome()
        {
            return nome;
        }

        public int GetIdade()
        {
            return idade;
        }
    }
}