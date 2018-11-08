using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.ApiServices;
using Newtonsoft.Json;

namespace CopaFilmes.Infra.Data.ApiDatas
{
    public class FilmeApiService : IFilmeApiService
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
