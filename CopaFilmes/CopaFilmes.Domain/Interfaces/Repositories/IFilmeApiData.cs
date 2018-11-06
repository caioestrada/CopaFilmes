using CopaFilmes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Interfaces.Repositories
{
    public interface IFilmeApiData
    {
        IEnumerable<Filme> ObterTodos();
    }
}
