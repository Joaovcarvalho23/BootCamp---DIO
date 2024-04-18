using ExemploFundamentos;
using ExemploFundamentos.models;
using System.Globalization;
    
// Solicita o nome do usuário, quilômetros percorridos por dia, 
        // Horas de uso de eletrônicos por dia e o número de refeições com carne:
        string nome = Console.ReadLine();
        double quilometrosPorDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int horasDeEletronicos = int.Parse(Console.ReadLine());
        int refeicoesComCarne = int.Parse(Console.ReadLine());

        // Chama o método para calcular a pegada de carbono
        double pegadaDeCarbono = CalcularPegadaDeCarbono(quilometrosPorDia, horasDeEletronicos, refeicoesComCarne);

        // Exiba o resultado para o usuário usando CultureInfo.InvariantCulture:
        Console.WriteLine(nome + ", sua pegada de carbono é de " + pegadaDeCarbono.ToString("F1", CultureInfo.InvariantCulture) +  " toneladas de CO2 por ano.");

        // Aguarda a entrada do usuário antes de encerrar o programa:
        Console.ReadLine();

          // Cria um método/função para calcular a pegada de carbono com base nos parâmetros fornecidos:
    static double CalcularPegadaDeCarbono(double quilometrosPorDia, int horasDeEletronicos, int refeicoesComCarne)
    {
        // Fatores de emissão para cada atividade
        double fatorTransporte = quilometrosPorDia * 365 * 0.2;
        double fatorEletronicos = horasDeEletronicos * 0.1;
        double fatorCarne = refeicoesComCarne * 0.5;

        // Calcula a pegada de carbono total
        double pegadaDeCarbonoTotal = fatorTransporte + fatorEletronicos + fatorCarne;

        return pegadaDeCarbonoTotal;
    }

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//  PessoaModel p1 = new PessoaModel();
//  PessoaModel p2 = new PessoaModel();

//  p1.Nome = "João";
//  p1.Idade = 22;
//  p1.Email = "joaovictor@gmail.com";
//  p1.Apresentar();

//  p2.Nome = "Pri";
//  p2.Idade = 24;
//  p2.Email = "primoura@gmail.com";
//  p2.Apresentar();

//  String apresentacao = "Seja bem vindo!";
//  int quantidade = 1;
//  double altura = 1.80;
//  decimal preco = 1.80m;
//  bool condicao = true;

//  Console.WriteLine($"\n{apresentacao}");
//  Console.WriteLine($"Valor da variável quantidade: {quantidade}");
//  Console.WriteLine($"Valor da variável altura: {altura.ToString("0.00")}");
//  Console.WriteLine($"Valor da variável preco: {preco}");
//  Console.WriteLine($"Valor da variável condicao: {condicao}");

// Calculadora calculo = new Calculadora();
// calculo.Somar(7, 9);
// calculo.Subtrair(7, 9);
// calculo.Subtrair(12, 4);
// calculo.Multiplicar(8, 5);
// calculo.Dividir(28, 2);
// calculo.Dividir(0, 9);
// calculo.Potencia(2, 4);
// calculo.Seno(30);
// calculo.Coseno(45);
// calculo.Tangente(45);
// calculo.RaizQuadrada(64);