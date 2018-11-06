using CopaFilmes.Application.ViewModel;
using System.Collections.Generic;

namespace CopaFilmes.Application.Interfaces
{
    public interface ICampeonatoAppService
    {
        List<FilmeViewModel> DefinirVencedoresDaPrimeiraFase(List<FilmeViewModel> filmesDaPrimeiraFase);
        List<FilmeViewModel> DefinirVencedoresDaFaseEliminatoria(List<FilmeViewModel> filmesDaFaseEliminatoria);
        FilmeViewModel DefinirCampeao(List<FilmeViewModel> finalistas);
    }
}
