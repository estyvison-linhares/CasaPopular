using CasaPopular.Interfaces;
using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Criterios
{
    public class CriterioDependentes3OuMais : ICriteriosPontuacao
    {
        public int CalcularPontos(Familia familia)
        {
            return familia.GetNumeroDeDependentes() >= 3 ? 3 : 0;
        }
    }
}
