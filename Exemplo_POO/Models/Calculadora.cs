using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exemplo_POO.Models.Interfaces;

namespace Exemplo_POO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subitrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}