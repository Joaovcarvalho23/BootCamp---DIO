using ExemploExplorando.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 15342.32M;

Console.WriteLine(valorMonetario.ToString("C8"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;
Console.WriteLine(numero.ToString("##-##-##"));














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