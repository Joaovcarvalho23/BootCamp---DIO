using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Professor : Pessoa // quando temos 'sealed', significa que essa classe é a instância final de uma herança. Ou seja, ela não pode ter mais classes filhas
    {
        // public Professor()
        // {

        // } //agora você pode determinar se quer passar algum valor ou não, pois agora tem dois construtores, um vazio e um com parâmetro

        // public Professor(string nome) : base(nome)
        // {
            
        // }

        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá! Sou o professor {Nome} e o meu salário é de {Salario} reais!");
        } // o método não pode mais ser instanciado por ninguém, pois está selado. Por isso que a classe Diretor não consegue herdar de Professor!
    }
}