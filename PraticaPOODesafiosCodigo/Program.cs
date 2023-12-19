using System;
using PraticaPOODesafiosCodigo.Models;

class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();
        string raca = Console.ReadLine();
        string classe = Console.ReadLine();

        Personagem p1 = new Personagem(nome, raca, classe);

        p1.Nivel = 1;
        p1.Vida = 10;

        p1.ExibirStatus();





























        // Jogador j1 = new Jogador();

        // string nome = Console.ReadLine();
        // string nacionalidade = Console.ReadLine();
        // int idade;
        // while(!int.TryParse(Console.ReadLine(), out idade))
        // {
        //     Console.WriteLine("Idade inválida.");
        // }
        // string posicao = Console.ReadLine();

        // j1.Novo(nome, nacionalidade, idade, posicao);

        // j1.ExibirInformacoes();






































        // string[] velocidades = Console.ReadLine().Split(' ');

        // int vmin;
        // while (!int.TryParse(velocidades[0], out vmin))
        // {
        //     Console.WriteLine("Velocidade mínima no formato inválido");
        // }

        // int vmax;
        // while (!int.TryParse(velocidades[1], out vmax))
        // {
        //     Console.WriteLine("Velocidade máxima no formato inválido");
        // }

        // Robo robot = new Robo(vmin, vmax);

        // string comandos = Console.ReadLine();

        // foreach (var item in comandos)
        // {
        //     if(item == 'A')
        //     {
        //         robot.Acelerar();
        //     }

        //     if(item == 'D')
        //     {
        //         robot.Desacelerar();
        //     }
        // }

        // Console.WriteLine(robot.VelocidadeAtual);
        


























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