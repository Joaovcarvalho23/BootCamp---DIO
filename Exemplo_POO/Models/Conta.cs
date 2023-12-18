using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é de {saldo}");
        }
    }
}