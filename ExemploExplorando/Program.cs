using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2023-12-16 18:00";

DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
/*O TryParseExact vai tentar converter  a representação de data "dataString", que pode não ser uma data válida, para um tipo DateTime, que é uma data válida. Ele vai tentar ler a data da forma que foi
passada anteriormente. Se invertermos a ordem, ele não vai conseguir ler. InvariantCulture independe de cultura, pois já temos um formato previamente. O mesmo vale para o DateTimeStyles.
Daí, se conseguir converter, jogamos o resultado a uma variável 'data'*/

Console.WriteLine(data);













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