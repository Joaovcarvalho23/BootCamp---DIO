using System;
using PraticaPOODesafiosCodigo.Models;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        int idade;
        while (!int.TryParse(Console.ReadLine(), out idade))
        {
            Console.WriteLine("Idade inválida. Por favor, digite um valor numérico para a idade.");
        }

        Pessoa p = new Pessoa(nome, idade);

        Console.WriteLine($"Nome: {p.nome}, Idade: {p.idade}");
    }
}