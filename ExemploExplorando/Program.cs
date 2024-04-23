using ExemploExplorando.Models;
using System.Globalization;

(int, string, string, decimal) tupla = (1, "João Victor", "Carvalho", 1.9M);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");








































// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("PE", "Pernambuco");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);
// Console.WriteLine("\n");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("-------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"\nVerificando o elemento: {chave}\n");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existnete: {chave}");
// } else{
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }










//new ExemploExecao().Metodo1();












// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException erro)
// {
//     Console.WriteLine($"\nOcorreu um erro na leitura do arquivo. Arquivo não encontrado. Mensagem do erro: {erro.Message}");
// }

// catch (DirectoryNotFoundException erro)
// {
//     Console.WriteLine($"\nOcorreu um erro na leitura do arquivo. Diretório não encontrado. Mensagem do erro: {erro.Message}");
// }
// catch (Exception erro)
// {
//     Console.WriteLine($"\nOcorreu um erro na leitura do arquivo. Exceção genérica. Mensagem do erro: {erro.Message}");
// }
// finally
// {
//     Console.WriteLine("Você chegou até aqui!!");
// }



















// string dataString = "2023-12-16 18:00";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
// /*O TryParseExact vai tentar converter  a representação de data "dataString", que pode não ser uma data válida, para um tipo DateTime, que é uma data válida. Ele vai tentar ler a data da forma que foi
// passada anteriormente. Se invertermos a ordem, ele não vai conseguir ler. InvariantCulture independe de cultura, pois já temos um formato previamente. O mesmo vale para o DateTimeStyles.
// Daí, se conseguir converter, jogamos o resultado a uma variável 'data'*/

// Console.WriteLine(data);

// if(sucesso)
// {
//     Console.WriteLine($"Conversão concluída com sucesso! Data: {data}");
// } else{
//     Console.WriteLine($"{dataString} não é uma data válida");
// }












// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 15342.32M;

// Console.WriteLine(valorMonetario.ToString("C8"));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));














// // Pessoa p1 = new Pessoa();
// // p1.Nome = "João Victor";
// // p1.Sobrenome = "Carvalho";
// Pessoa p1 = new Pessoa(nome: "João Victor", sobrenome: "Carvalho");

// // Pessoa p2 = new Pessoa();
// // p2.Nome = "Priscylla";
// // p2.Sobrenome = "Moura";
// Pessoa p2 = new Pessoa(nome: "Priscylla", sobrenome: "Moura");

// Curso cursoIngles = new Curso();
// cursoIngles.Nome = "Inglês";
// cursoIngles.Alunos = new List<Pessoa>();

// cursoIngles.AdicionarAluno(p1);
// cursoIngles.AdicionarAluno(p2);
// cursoIngles.ListarAlunos();