using CopaFilmes.Domain.Entities;
using System.Collections.Generic;

namespace CopaFilmes.Domain.Test.MockTest
{
    public static class FilmeMock
    {
        public static List<Filme> Filmes { get; private set; } = new List<Filme>()
        {
            new Filme{ Id = "tt3606756", PrimaryTitle = "Os Incríveis 2", Year = 2018, AverageRating = 8.5m },
            new Filme{ Id = "tt4881806", PrimaryTitle = "Jurassic World: Reino Ameaçado", Year = 2018, AverageRating = 6.7m },
            new Filme{ Id = "tt5164214", PrimaryTitle = "Oito Mulheres e um Segredo", Year = 2018, AverageRating = 6.3m },
            new Filme{ Id = "tt7784604", PrimaryTitle = "Hereditário", Year = 2018, AverageRating = 7.8m },
            new Filme{ Id = "tt4154756", PrimaryTitle = "Vingadores: Guerra Infinita", Year = 2018, AverageRating = 8.8m },
            new Filme{ Id = "tt5463162", PrimaryTitle = "Deadpool 2", Year = 2018, AverageRating = 8.1m },
            new Filme{ Id = "tt3778644", PrimaryTitle = "Han Solo: Uma História Star Wars", Year = 2018, AverageRating = 7.2m },
            new Filme{ Id = "tt3501632", PrimaryTitle = "Thor: Ragnarok", Year = 2017, AverageRating = 7.9m }
        };
    }
}
