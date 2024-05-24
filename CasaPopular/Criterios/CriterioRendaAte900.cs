using CasaPopular.Interfaces;
using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Criterios
{
    public class CriterioRendaAte900 : ICriteriosPontuacao
    {
        public int CalcularPontos(Familia familia)
        {
            return familia.GetRendaTotal() <= 900 ? 5 : 0;
        }
    }
}
