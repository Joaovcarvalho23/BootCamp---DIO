using System;
using PraticaPOODesafiosCodigo.Models;

class Program
{
    static void Main()
    {
        string[] velocidades = Console.ReadLine().Split(' ');

        int vmin;
        while (!int.TryParse(velocidades[0], out vmin))
        {
            Console.WriteLine("Velocidade mínima no formato inválido");
        }

        int vmax;
        while (!int.TryParse(velocidades[1], out vmax))
        {
            Console.WriteLine("Velocidade máxima no formato inválido");
        }

        Robo robot = new Robo(vmin, vmax);

        string comandos = Console.ReadLine();

        foreach (var item in comandos)
        {
            if(item == 'A')
            {
                robot.Acelerar();
            }

            if(item == 'D')
            {
                robot.Desacelerar();
            }
        }

        Console.WriteLine(robot.VelocidadeAtual);
        


























        // string nome = Console.ReadLine();
        // int idade;
        // while (!int.TryParse(Console.ReadLine(), out idade))
        // {
        //     Console.WriteLine("Idade inválida. Por favor, digite um valor numérico para a idade.");
        // }

        // Pessoa p = new Pessoa(nome, idade);

        // Console.WriteLine($"Nome: {p.nome}, Idade: {p.idade}");
    }
}