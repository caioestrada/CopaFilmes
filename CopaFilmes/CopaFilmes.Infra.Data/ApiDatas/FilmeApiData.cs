using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.ApiDatas;
using Newtonsoft.Json;

namespace CopaFilmes.Infra.Data.ApiDatas
{
    public class FilmeApiData : IFilmeApiData
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
