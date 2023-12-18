using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        } //agora você pode determinar se quer passar algum valor ou não, pois agora tem dois construtores, um vazio e um com parâmetro
        
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }


        public virtual void Apresentar() // o virtual me permite sobrescrever métodos e adaptá-los da forma que quisermos!
        {
            Console.WriteLine($"Olá! Meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }
}