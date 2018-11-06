using AutoMapper;
using CopaFilmes.Application.Interfaces;
using CopaFilmes.Application.ViewModel;
using CopaFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Application.Services
{
    public class FilmeAppService : IFilmeAppService
    {
        private readonly IFilmeService _filmeService;

        public FilmeAppService(IFilmeService filmeService) => _filmeService = filmeService;

        public IEnumerable<FilmeViewModel> ObterTodos() => Mapper.Map<IEnumerable<FilmeViewModel>>(_filmeService.ObterTodos());
    }
}
