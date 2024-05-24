using CasaPopular.Interfaces;
using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Criterios
{
    public class CriterioRendaAte1500 : ICriteriosPontuacao
    {
        public int CalcularPontos(Familia familia)
        {
            double renda = familia.GetRendaTotal();
            return renda > 900 && renda <= 1500 ? 3 : 0;
        }
    }
}
