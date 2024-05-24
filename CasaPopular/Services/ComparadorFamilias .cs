using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Services
{
    public class ComparadorFamilias : IComparer<Familia>
    {
        private readonly CalculadorDePontos calculadorDePontos;

        public ComparadorFamilias(CalculadorDePontos calculadorDePontos)
        {
            this.calculadorDePontos = calculadorDePontos;
        }

        public int Compare(Familia? familia1, Familia? familia2)
        {
            // Se ambos são null, são considerados iguais
            if (familia1 == null && familia2 == null)
            {
                return 0;
            }

            // Se apenas familia1 é null, ele é considerado maior para ordenação
            if (familia1 == null)
            {
                return 1;
            }

            // Se apenas f2 é null, ele é considerado maior para ordenação
            if (familia2 == null)
            {
                return -1;
            }

            int pontosFamilia1 = calculadorDePontos.CalcularPontos(familia1);
            int pontosFamilia2 = calculadorDePontos.CalcularPontos(familia2);

            // Comparar de forma decrescente
            return pontosFamilia2.CompareTo(pontosFamilia1);
        }
    }
}
