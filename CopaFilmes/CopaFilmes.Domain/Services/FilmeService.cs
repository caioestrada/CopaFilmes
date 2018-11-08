using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.ApiServices;
using CopaFilmes.Domain.Interfaces.Services;

namespace CopaFilmes.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeApiService _filmeApiData;

        public FilmeService(IFilmeApiService filmeApiData) => _filmeApiData = filmeApiData;

        public IEnumerable<Filme> ObterTodos() => _filmeApiData.ObterTodos().Skip(0).Take(16);
    }
}
