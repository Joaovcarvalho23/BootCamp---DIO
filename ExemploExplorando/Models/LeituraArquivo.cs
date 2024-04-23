using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QtdLinhas) LerArquivo(string path) //vai retornar um bool, um array de linhas e um int
        {
            try
            {
                string[] linhas = File.ReadAllLines(path);
                return (true, linhas, linhas.Count());
            } catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}