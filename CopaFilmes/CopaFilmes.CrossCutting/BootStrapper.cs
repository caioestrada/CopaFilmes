using CopaFilmes.Application.Interfaces;
using CopaFilmes.Application.Services;
using CopaFilmes.Domain.Interfaces.Repositories;
using CopaFilmes.Domain.Interfaces.Services;
using CopaFilmes.Domain.Services;
using CopaFilmes.Infra.Data.Repositories;
using SimpleInjector;

namespace CopaFilmes.CrossCutting
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            //App
            container.Register<IFilmeAppService, FilmeAppService>(Lifestyle.Scoped);

            //Domain
            container.Register<IFilmeService, FilmeService>(Lifestyle.Scoped);

            //Data
            container.Register<IFilmeApiData, FilmeApiData>(Lifestyle.Scoped);
        }
    }
}
