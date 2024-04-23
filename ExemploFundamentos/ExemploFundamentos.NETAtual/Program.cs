using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int i = 0; i <3; i++)
        {
            string item = Console.ReadLine();
            itens.Add(item);
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int saldoTotal = int.Parse(Console.ReadLine());
//         int valorSaque = int.Parse(Console.ReadLine());
        
//         string resultado = RealizarSaque(saldoTotal, valorSaque);
//         Console.WriteLine(resultado);
//     }

//     static string RealizarSaque(int saldoTotal, int valorSaque)
//     {
//         if (saldoTotal >= valorSaque)
//         {
//             int novoSaldo = saldoTotal - valorSaque;
//             return $"Saque realizado com sucesso! Novo saldo: {novoSaldo}";
//         }
//         else
//         {
//             return "Saldo insuficiente. Saque não realizado!";
//         }
//     }
// }
