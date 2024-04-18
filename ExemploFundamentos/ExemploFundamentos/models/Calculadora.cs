using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos
{
    public class Calculadora
    {
        public void Somar (int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"{a} + {b} = {resultado}");
        }

        public void Subtrair(int a, int b)
        {
            int resultado;

            if(a >= b){
                resultado = a - b;
                Console.WriteLine($"{a} - {b} = {resultado}");

            } else{
                resultado = b - a;
                Console.WriteLine($"{b} - {a} = {resultado}");
            }
        }

        public void Multiplicar (int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"{a} x {b} = {resultado}");
        }

        public void Dividir (int a, int b)
        {
            int resultado = a / b;

            if(a == 0){
                Console.WriteLine("0 não pode ser dividido por nenhum número. Por favor, escreva um número válido");

            } else{
                Console.WriteLine($"{a} / {b} = {resultado}");
            }
        }

        public void Potencia (int a, int b)
        {
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"{a} ^ {b} = {resultado}");

        }

        public void Seno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O Seno de {angulo} é igual a: {Math.Round(seno, 4)}");
        }

        public void Coseno (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"O Coseno de {angulo} é igual a: {Math.Round(coseno, 4)}");
        }

        public void Tangente (double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"A Tangente de {angulo} é igual a: {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada (double a)
        {
           double raiz = Math.Sqrt(a);
           Console.WriteLine($"A raiz quadrada de {a}: {Math.Round(raiz, 2)}");
        }
    }
}