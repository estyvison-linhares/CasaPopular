using CasaPopular.Interfaces;
using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Criterios
{
    public class CriterioDependentes1Ou2 : ICriteriosPontuacao
    {
        public int CalcularPontos(Familia familia)
        {
            int dependentes = familia.GetNumeroDeDependentes();
            return (dependentes == 1 || dependentes == 2) ? 2 : 0;
        }
    }
}
