using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Professor : Pessoa
    {
        public Professor()
        {

        } //agora você pode determinar se quer passar algum valor ou não, pois agora tem dois construtores, um vazio e um com parâmetro

        public Professor(string nome) : base(nome)
        {
            
        }

        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá! Sou o professor {Nome} e o meu salário é de {Salario} reais!");
        }
    }
}