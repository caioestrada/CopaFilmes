using CopaFilmes.Application.ViewModel;
using System.Collections.Generic;

namespace CopaFilmes.Application.Interfaces
{
    public interface ICampeonatoAppService
    {
        CampeonatoViewModel CampeonatoViewModel { get; }

        void RelizarCampeonato(IEnumerable<FilmeViewModel> filmesSelecionados);
    }
}
