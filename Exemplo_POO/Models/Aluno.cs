using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Aluno : Pessoa
    {
        // public Aluno()
        // {

        // } //agora você pode determinar se quer passar algum valor ou não, pois agora tem dois construtores, um vazio e um com parâmetro

        // public Aluno(string nome) : base(nome)
        // {
            
        // }

        public double Nota { get; set; }
        
        public override void Apresentar()
        { 
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou um aluno nota {Nota}");
        }
    }
}