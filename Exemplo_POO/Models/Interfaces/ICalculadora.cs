using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subitrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2);
    }
}