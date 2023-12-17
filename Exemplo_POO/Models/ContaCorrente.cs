using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_POO.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo { get; set; }


        public ContaCorrente(int nuemroConta, decimal saldoInicial)
        {
            NumeroConta = nuemroConta;
            Saldo = saldoInicial;
        }

        public void Sacar(decimal valor)
        {
            if(Saldo >= valor)
            {
                Saldo -= valor; //Saldo = Saldo - valor
                Console.WriteLine($"Seu saque no valor de R$ {valor},00 foi realizado com sucesso!");
            }
            else
            {
                Console.WriteLine($"O valor desejado é maior que o saldo.");
            }
        }

        public void ExibirSaldo ()
        {
            Console.WriteLine($"Seu saldo disponível é de {Saldo}");
        }
    }
}