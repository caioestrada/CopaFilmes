using CopaFilmes.Domain.Entities;
using CopaFilmes.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopaFilmes.Domain.Services
{
    public static class PartidaService
    {
        public static Filme RealizarDisputaEntreDoisTimes(Filme primeiroFilme, Filme segundoFilme)
        {
            if (primeiroFilme.AverageRating == segundoFilme.AverageRating)
                return DesempatarEmCasoDeMesmaNota(primeiroFilme, segundoFilme);

            return primeiroFilme.AverageRating > segundoFilme.AverageRating ? primeiroFilme : segundoFilme;
        }

        private static Filme DesempatarEmCasoDeMesmaNota(Filme primeiroFilme, Filme segundoFilme)
        {
            return new List<Filme>() { primeiroFilme, segundoFilme }.OrderBy(x => x.PrimaryTitle).FirstOrDefault();
        }
    }
}
