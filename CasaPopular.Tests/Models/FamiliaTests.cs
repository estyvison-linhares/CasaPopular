using CasaPopular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaPopular.Tests.Models
{
    
    [TestFixture]
    public class FamiliaTests
    {
        [Test]
        public void GetRendaTotal_DeveRetornarSomaDasRendas()
        {
            var membros = new List<Pessoa>
            {
                new Pessoa("João", 35, 500),
                new Pessoa("Maria", 34, 400),
                new Pessoa("Pedro", 5, 0)
            };
            var familia = new Familia(membros);

            double rendaTotal = familia.GetRendaTotal();
            double rendaTeste = 900;

            Assert.That(rendaTeste, Is.EqualTo(rendaTotal));
        }

        [Test]
        public void GetNumeroDeDependentes_DeveRetornarNumeroDeDependentesMenoresDe18Anos()
        {
            var membros = new List<Pessoa>
                    {
                        new Pessoa("João", 35, 500),
                        new Pessoa("Maria", 34, 400),
                        new Pessoa("Pedro", 5, 0),
                        new Pessoa("Ana", 18, 0) 
                    };
            var familia = new Familia(membros);

            int numeroDeDependentes = familia.GetNumeroDeDependentes();
            int numeroDependentesTeste = 1;

            Assert.That(numeroDependentesTeste, Is.EqualTo(numeroDeDependentes));
        }
    }
}