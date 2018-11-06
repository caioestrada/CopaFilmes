using AutoMapper;
using CopaFilmes.Application.Interfaces;
using CopaFilmes.Application.ViewModel;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Application.Services
{
    public class CampeonatoAppService : ICampeonatoAppService
    {
        private readonly ICampeonatoService _campeonatoService;

        public CampeonatoAppService(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
        }

        public List<FilmeViewModel> DefinirVencedoresDaPrimeiraFase(List<FilmeViewModel> filmesDaPrimeiraFase)
        {
            return Mapper.Map<List<FilmeViewModel>>(_campeonatoService.DefinirVencedoresDaPrimeiraFase(Mapper.Map<List<Filme>>(filmesDaPrimeiraFase)));
        }

        public List<FilmeViewModel> DefinirVencedoresDaFaseEliminatoria(List<FilmeViewModel> filmesDaFaseEliminatoria)
        {
            return Mapper.Map<List<FilmeViewModel>>(_campeonatoService.DefinirVencedoresDaFaseEliminatoria(Mapper.Map<List<Filme>>(filmesDaFaseEliminatoria)));
        }

        public FilmeViewModel DefinirCampeao(List<FilmeViewModel> finalistas)
        {
            return Mapper.Map<FilmeViewModel>(_campeonatoService.DefinirCampeao(Mapper.Map<List<Filme>>(finalistas)));
        }
    }
}
