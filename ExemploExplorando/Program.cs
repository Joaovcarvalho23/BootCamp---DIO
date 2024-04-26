using ExemploExplorando.Models;
using Newtonsoft.Json;
using System.Globalization;

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda itemVenda in listaVenda)
// {
//     Console.WriteLine($"Id: {itemVenda.Id}, Produto: {itemVenda.Produto}, Preço: {itemVenda.Preco}, "+
//                       $"Data da venda: {itemVenda.DataDaVenda.ToString("dd/MM/yyyy")} às {itemVenda.DataDaVenda.ToString("HH:mm")}");    
// }































































// class Program
// {
//     static string VerificarForcaSenha(string senha)
//     {
//         int comprimentoMinimo = 8;
//         bool temLetraMaiuscula = false;
//         bool temLetraMinuscula = false;
//         bool temNumero = false;
//         bool temCaractereEspecial = false;

//         // TODO: Verifique o comprimento da senha
//         if(senha.Length < 8)
//            return "Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.";
        

//         // Verificando se a senha contém letras maiúsculas e minúsculas
//         temLetraMaiuscula = senha.Any(char.IsUpper);
//         temLetraMinuscula = senha.Any(char.IsLower);

//         // Verificando se a senha contém sequências comuns
//         string[] sequenciasComuns = { "123456", "abcdef" };
//         if (sequenciasComuns.Any(s => senha.Contains(s)))
//             return "Sua senha contem uma sequencia comum. Tente uma senha mais complexa.";

//         // Verificando se a senha contém palavras comuns
//         string[] palavrasComuns = { "password", "123456", "qwerty" };
//         if (palavrasComuns.Contains(senha))
//             return "Sua senha e muito comum. Tente uma senha mais complexa.";

//         // Verificando se a senha contém números e caracteres especiais
//         temNumero = senha.Any(char.IsDigit);
//         temCaractereEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

//         if (temLetraMinuscula && temLetraMaiuscula && temNumero && temCaractereEspecial)
//             return "Sua senha atende aos requisitos de seguranca. Parabens!";
//         else
//             return "Sua senha nao atende aos requisitos de seguranca.";
//     }

//     static void Main(string[] args)
//     {
//         string senha = Console.ReadLine().Trim();

//         string resultado = VerificarForcaSenha(senha);

//         Console.WriteLine(resultado);
//     }
// }





























// DateTime dataAtual = DateTime.Now;

// List<Vendas> listaDeVendas = new List<Vendas>(); //coleção de objetos do tipo Vendas

// Vendas v1 = new Vendas(1, "Material escolar", 27.00M, dataAtual);
// Vendas v2 = new Vendas(2, "Roupas", 30.00M, dataAtual);
// Vendas v3 = new Vendas(3, "Fones", 45.00M, dataAtual);
// Vendas v4 = new Vendas(4, "Sapatos", 80.00M, dataAtual);

// listaDeVendas.Add(v1);
// listaDeVendas.Add(v2);
// listaDeVendas.Add(v3);
// listaDeVendas.Add(v4);

// string v1Serializado = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented); //estamos convertendo o objeto v1 para o formato JSON, para que ele possa ser lido por outras ferramentas

// File.WriteAllText("Arquivos/vendas.json", v1Serializado);

// Console.WriteLine(v1Serializado);












































// int numero = 23;
// bool ehPar;

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O numero {numero} eh {(ehPar ? "par" : "impar")}" );
































// Pessoa p1 = new Pessoa("Joao Victor", "Carvalho");

// (string nome, string sobrenome) = p1; //aqui vamos desconstruir o nome e o sobrenome

// Console.WriteLine($"Nome completo: {nome} {sobrenome}");




































// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); //descarta a ultima opcao. Pois so vou querer reternar as duas primeiras

// if(sucesso)
// {
//     // Console.WriteLine($"Quantidade de linhas no arquivo: {quantidadeLinhas}");
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Nao foi possivel ler o arquivo");
// }







































// (int, string, string, decimal) tupla = (1, "João Victor", "Carvalho", 1.9M);

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");








































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