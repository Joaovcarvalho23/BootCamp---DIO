using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;


        public Pessoa()
        {
            
        }


        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        public void Deconstruct(out string nome, out string sobrenome) //o out serve para descontruir o nome e o sobrenome
        { //out = parametro de saida
            nome = Nome;
            sobrenome = Sobrenome;
        }
        

        public string? Nome
        { 
            get => _nome; //CONVERTENDO PARA BODY EXPRESSIONS
            
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio!");
                }

                _nome = value;
            }
       
        }

        public int Idade
        { 
            get => _idade;

            set
            {
                if(value < 0)  throw new ArgumentException("A idade não pode ser menor que zero!");

                _idade = value;
            }
        }


        public string? Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}