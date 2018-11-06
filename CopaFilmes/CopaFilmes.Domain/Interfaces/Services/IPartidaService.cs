using CopaFilmes.Domain.Entities;

namespace CopaFilmes.Domain.Interfaces.Services
{
    public interface IPartidaService
    {
        Filme RealizarDisputaEntreDoisTimes(Filme primeiroFilme, Filme segundoFilme);
    }
}
