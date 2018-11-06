﻿using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.Repositories;
using Newtonsoft.Json;

namespace CopaFilmes.Infra.Data.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        public IEnumerable<Filme> ObterTodos()
        {
            using (var client = new HttpClient())
            {
                var filmesApi = client.GetStringAsync(ConfigurationManager.AppSettings["ApiFilmes"]).Result;
                return JsonConvert.DeserializeObject<List<Filme>>(filmesApi);
            }
        }
    }
}
