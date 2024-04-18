using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.models
{
    public class PessoaModel
    {
        public String? Nome { get; set; }
        public int Idade { get; set; }
        public String? Email { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"\nOlá! Me chamo {Nome} e tenho {Idade} anos.\nEmail para contato: {Email}");
        }
    }
}