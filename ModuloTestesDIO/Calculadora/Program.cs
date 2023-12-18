
using Calculadora.Services;

CalculadoraImplementacao calculadora = new CalculadoraImplementacao();

int n1 = 5;
int n2 = 10;

Console.WriteLine($"{n1} + {n2} = {calculadora.Somar(n1, n2)}");