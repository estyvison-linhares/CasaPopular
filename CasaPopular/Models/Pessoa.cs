using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Models
{
    public class Pessoa
    {
        public string Nome { get; }
        public int Idade { get; }
        public double Renda { get; }

        public Pessoa(string nome, int idade, double renda)
        {
            Nome = nome;
            Idade = idade;
            Renda = renda;
        }
    }
}
