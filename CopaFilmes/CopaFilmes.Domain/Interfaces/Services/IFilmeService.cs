using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Interfaces.Services
{
    public interface IFilmeService
    {
        IEnumerable<Filme> ObterTodos();
    }
}
