using ExemploFundamentos.models;

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

 PessoaModel p1 = new PessoaModel();
 PessoaModel p2 = new PessoaModel();

 p1.Nome = "João";
 p1.Idade = 22;
 p1.Email = "joaovictor@gmail.com";
 p1.Apresentar();

 p2.Nome = "Pri";
 p2.Idade = 24;
 p2.Email = "primoura@gmail.com";
 p2.Apresentar();

 String apresentacao = "Seja bem vindo!";
 int quantidade = 1;
 double altura = 1.80;
 decimal preco = 1.80m;
 bool condicao = true;

 Console.WriteLine($"\n{apresentacao}");
 Console.WriteLine($"Valor da variável quantidade: {quantidade}");
 Console.WriteLine($"Valor da variável altura: {altura.ToString("0.00")}");
 Console.WriteLine($"Valor da variável preco: {preco}");
 Console.WriteLine($"Valor da variável condicao: {condicao}");