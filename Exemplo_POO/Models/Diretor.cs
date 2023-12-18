using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class Diretor : Professor //Diretor não consegue instanciar de Professor, pois Professor é uma classe selada
    {
        public override void Apresentar() //dá erro, pois esse método na classe Professor é selado!!!
        {
            Console.WriteLine($"Sou Diretor");
        }
    }
}