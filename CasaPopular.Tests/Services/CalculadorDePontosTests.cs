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
    public class CalculadorDePontosTests
    {
        private CalculadorDePontos calculador;

        [SetUp]
        public void Setup()
        {
            calculador = new CalculadorDePontos();
            calculador.AdicionarCriterio(new CriterioRendaAte900());
            calculador.AdicionarCriterio(new CriterioRendaAte1500());
            calculador.AdicionarCriterio(new CriterioDependentes3OuMais());
            calculador.AdicionarCriterio(new CriterioDependentes1Ou2());
        }

        [Test]
        public void CalcularPontos_DeveRetornarPontosCorretosParaFamiliaAte900()
        {
            var membros = new List<Pessoa>
            {
                new Pessoa("João", 35, 500),
                new Pessoa("Maria", 34, 400),
                new Pessoa("Pedro", 5, 0)
            };
            var familia = new Familia(membros);

            int pontos = calculador.CalcularPontos(familia);
            int testeDePontos = 7;

            Assert.That(testeDePontos, Is.EqualTo(pontos)); 
        }

        [Test]
        public void CalcularPontos_DeveRetornarPontosCorretosParaFamiliaComRendaAte1500()
        {
            var membros = new List<Pessoa>
            {
                new Pessoa("Ana", 30, 800),
                new Pessoa("Carlos", 32, 600)
            };
            var familia = new Familia(membros);

            int pontos = calculador.CalcularPontos(familia);
            int testeDePontos = 3;

            Assert.That(testeDePontos, Is.EqualTo(pontos)); 
        }
    }
}
