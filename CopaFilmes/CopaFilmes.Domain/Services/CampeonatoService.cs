﻿using CopaFilmes.Domain.Entities;
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
            for(int i = 0; i < filmesDaPrimeiraFase.Count / 2; i++)
            {
                var primeiroFilme = filmesDaPrimeiraFase[i];
                var ultimoFilme = filmesDaPrimeiraFase[filmesDaPrimeiraFase.Count() - (i + 1)];

                filmesVencedores.Add(RealizarConfronto(primeiroFilme, ultimoFilme));
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

        public Filme DefinirVice(List<Filme> finalistas)
        {
            var vencedor = RealizarConfronto(finalistas.FirstOrDefault(), finalistas.Skip(1).Take(1).SingleOrDefault());
            return finalistas.Where(x => x.Id != vencedor.Id).FirstOrDefault();
        }

        private Filme RealizarConfronto(Filme primeiroFilmeDoConfronto, Filme segundoFilmeDoConfronto)
        {
            return _partidaService.RealizarDisputaEntreDoisTimes(primeiroFilmeDoConfronto, segundoFilmeDoConfronto);
        }
    }
}
