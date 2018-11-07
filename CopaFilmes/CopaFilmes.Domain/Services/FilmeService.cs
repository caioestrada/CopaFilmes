using System.Collections.Generic;
using System.Linq;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.ApiDatas;
using CopaFilmes.Domain.Interfaces.Services;

namespace CopaFilmes.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeApiData _filmeApiData;

        public FilmeService(IFilmeApiData filmeApiData) => _filmeApiData = filmeApiData;

        public IEnumerable<Filme> ObterTodos() => _filmeApiData.ObterTodos().Skip(new System.Random().Next(40)).Take(16);
    }
}
