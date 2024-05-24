using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Models
{
    public class Familia
    {
        public List<Pessoa> Membros { get; }

        public Familia(List<Pessoa> membros)
        {
            Membros = membros;
        }

        public double GetRendaTotal()
        {
            return Membros.Sum(m => m.Renda);
        }

        public int GetNumeroDeDependentes()
        {
            return Membros.Count(m => m.Idade < 18);
        }
    }
}



