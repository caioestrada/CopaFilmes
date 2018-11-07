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
        public CampeonatoViewModel CampeonatoViewModel { get; set; }

        public CampeonatoAppService(ICampeonatoService campeonatoService)
        {
            _campeonatoService = campeonatoService;
            CampeonatoViewModel = new CampeonatoViewModel();
        }

        public void RelizarCampeonato(IEnumerable<FilmeViewModel> filmesSelecionados)
        {
            var vencedoresDaPrimeiraFase =_campeonatoService.DefinirVencedoresDaPrimeiraFase(Mapper.Map<List<Filme>>(filmesSelecionados));
            var finalistas = _campeonatoService.DefinirVencedoresDaFaseEliminatoria(vencedoresDaPrimeiraFase);
            this.CampeonatoViewModel.Campeao = Mapper.Map<FilmeViewModel>(_campeonatoService.DefinirCampeao(finalistas));
            this.CampeonatoViewModel.ViceCampeao = Mapper.Map<FilmeViewModel>(_campeonatoService.DefinirVice(finalistas));
        }
    }
}
