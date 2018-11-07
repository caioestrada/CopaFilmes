using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces.Services
{
    public interface ICampeonatoService
    {
        List<Filme> DefinirVencedoresDaPrimeiraFase(List<Filme> filmesDaPrimeiraFase);
        List<Filme> DefinirVencedoresDaFaseEliminatoria(List<Filme> filmesDaFaseEliminatoria);
        Filme DefinirCampeao(List<Filme> finalistas);
        Filme DefinirVice(List<Filme> finalistas);
    }
}
