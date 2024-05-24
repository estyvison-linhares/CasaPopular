using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Interfaces
{
    public interface ICriteriosPontuacao
    {
        int CalcularPontos(Familia familia);
    }
}
