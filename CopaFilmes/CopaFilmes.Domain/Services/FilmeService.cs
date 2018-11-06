using System.Collections.Generic;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.Repositories;
using CopaFilmes.Domain.Interfaces.Services;

namespace CopaFilmes.Domain.Services
{
    public class FilmeService : IFilmeService
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeService(IFilmeRepository filmeRepository) => _filmeRepository = filmeRepository;

        public IEnumerable<Filme> ObterTodos() => _filmeRepository.ObterTodos();
    }
}
