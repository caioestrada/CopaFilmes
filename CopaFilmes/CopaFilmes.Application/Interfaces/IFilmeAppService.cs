using CopaFilmes.Application.ViewModel;
using System.Collections.Generic;

namespace CopaFilmes.Application.Interfaces
{
    public interface IFilmeAppService
    {
        IEnumerable<FilmeViewModel> ObterTodos();
    }
}
