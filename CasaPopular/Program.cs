using CasaPopular.Criterios;
using CasaPopular.Models;
using CasaPopular.Services;

var familias = new List<Familia>
            {
                new Familia(new List<Pessoa>
                {
                    new Pessoa("João", 35, 500),
                    new Pessoa("Maria", 34, 400),
                    new Pessoa("Pedro", 5, 0)
                }),
                new Familia(new List<Pessoa>
                {
                    new Pessoa("Ana", 30, 800),
                    new Pessoa("Carlos", 32, 600)
                }),
                new Familia(new List<Pessoa>
                {
                    new Pessoa("José", 30, 3000),
                    new Pessoa("Alberto", 4, 0)
                })
            };

var calculador = new CalculadorDePontos();
calculador.AdicionarCriterio(new CriterioRendaAte900());
calculador.AdicionarCriterio(new CriterioRendaAte1500());
calculador.AdicionarCriterio(new CriterioDependentes3OuMais());
calculador.AdicionarCriterio(new CriterioDependentes1Ou2());

var comparador = new ComparadorFamilias(calculador);
familias.Sort(comparador);

foreach (var familia in familias)
{
    if(familia != null)
    {
        Console.WriteLine($"A Familia com renda total de {familia.GetRendaTotal()} tem {calculador.CalcularPontos(familia)} pontos.");
    } else
    {
        return;
    }
}
        