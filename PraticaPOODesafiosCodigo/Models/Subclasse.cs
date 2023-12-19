using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticaPOODesafiosCodigo.Models
{
    public class Subclasse : Personagem
    {
        public int DanoBase { get; set; }

        public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
        {
            DanoBase = danoBase;
        }

        public void CalcularDano()
        {
            Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
        }
    }
}