using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Services
{
    public class CampeonatoService : ICampeonatoService
    {
        private readonly IPartidaService _partidaService;

        public CampeonatoService(IPartidaService partidaService)
        {
            _partidaService = partidaService;
        }

        public List<Filme> DefinirVencedoresDaPrimeiraFase(List<Filme> filmesDaPrimeiraFase)
        {
            var filmesVencedores = new List<Filme>();
            filmesDaPrimeiraFase = filmesDaPrimeiraFase.OrderBy(x => x.PrimaryTitle).ToList();
            foreach (var filme in filmesDaPrimeiraFase.ToList())
            {
                var primeiroFilme = filme;
                var ultimoFilme = filmesDaPrimeiraFase.LastOrDefault();
                
                filmesVencedores.Add(RealizarConfronto(primeiroFilme, ultimoFilme));

                filmesDaPrimeiraFase.Remove(primeiroFilme);
                filmesDaPrimeiraFase.Remove(ultimoFilme);

                if (filmesDaPrimeiraFase.Count == 0)
                    break;
            }

            return filmesVencedores;
        }

        public List<Filme> DefinirVencedoresDaFaseEliminatoria(List<Filme> filmesDaFaseEliminatoria)
        {
            var filmesVencedores = new List<Filme>();
            filmesVencedores.Add(RealizarConfronto(filmesDaFaseEliminatoria.FirstOrDefault(), filmesDaFaseEliminatoria.Skip(1).Take(1).SingleOrDefault()));
            filmesVencedores.Add(RealizarConfronto(filmesDaFaseEliminatoria.Skip(2).Take(1).SingleOrDefault(), filmesDaFaseEliminatoria.Skip(3).Take(1).SingleOrDefault()));

            return filmesVencedores;
        }

        public Filme DefinirCampeao(List<Filme> finalistas)
        {
            return RealizarConfronto(finalistas.FirstOrDefault(), finalistas.Skip(1).Take(1).SingleOrDefault());
        }

        private Filme RealizarConfronto(Filme primeiroFilmeDoConfronto, Filme segundoFilmeDoConfronto)
        {
            return _partidaService.RealizarDisputaEntreDoisTimes(primeiroFilmeDoConfronto, segundoFilmeDoConfronto);
        }
    }
}
