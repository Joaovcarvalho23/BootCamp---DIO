using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImplementacao
    {
        public int Somar (int n1, int n2)
        {
            return n1 + n2;
            //return n1 + n2 + 1; retorna uma falha!!
        }

        public bool EhPar (int numero)
        {
            return numero % 2 == 0;
        }
    }
}