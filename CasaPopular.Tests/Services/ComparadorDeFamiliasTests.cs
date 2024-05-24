using CasaPopular.Criterios;
using CasaPopular.Models;
using CasaPopular.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Tests.Services
{
    [TestFixture]
    public class ComparadorDeFamiliasTests
    {
        private CalculadorDePontos calculadorDePontos;
        private ComparadorFamilias comparadorDeFamilias;

        [SetUp]
        public void Setup()
        {
            calculadorDePontos = new CalculadorDePontos();
            calculadorDePontos.AdicionarCriterio(new CriterioRendaAte900());
            calculadorDePontos.AdicionarCriterio(new CriterioRendaAte1500());
            calculadorDePontos.AdicionarCriterio(new CriterioDependentes3OuMais());
            calculadorDePontos.AdicionarCriterio(new CriterioDependentes1Ou2());
            comparadorDeFamilias = new ComparadorFamilias(calculadorDePontos);
        }

        [Test]
        public void Compare_DeveOrdenarFamiliasPorPontuacao()
        {
            var familia1 = new Familia(new List<Pessoa>
            {
                new Pessoa("João", 35, 500),
                new Pessoa("Maria", 34, 400),
                new Pessoa("Pedro", 5, 0)
            });

            var familia2 = new Familia(new List<Pessoa>
            {
                new Pessoa("Ana", 30, 800),
                new Pessoa("Carlos", 32, 600)
            });

            var familias = new List<Familia> { familia2, familia1 };

            familias.Sort(comparadorDeFamilias);

            Assert.Multiple(() =>
            {
                Assert.That(familia1, Is.EqualTo(familias[0]));
                Assert.That(familia2, Is.EqualTo(familias[1]));
            });
        }
    }
}
