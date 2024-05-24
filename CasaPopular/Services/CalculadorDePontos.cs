using CasaPopular.Interfaces;
using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Services
{
    public class CalculadorDePontos
    {
        private List<ICriteriosPontuacao> criterios = new List<ICriteriosPontuacao>();

        public void AdicionarCriterio(ICriteriosPontuacao criterio)
        {
            criterios.Add(criterio);
        }

        public int CalcularPontos(Familia familia)
        {
            int pontos = 0;
            foreach (var criterio in criterios)
            {
                pontos += criterio.CalcularPontos(familia);
            }
            return pontos;
        }
    }
}
