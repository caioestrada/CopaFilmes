using CopaFilmes.Application.Interfaces;
using CopaFilmes.Application.Services;
using CopaFilmes.Domain.Interfaces.ApiServices;
using CopaFilmes.Domain.Interfaces.Services;
using CopaFilmes.Domain.Services;
using CopaFilmes.Infra.Data.ApiDatas;
using SimpleInjector;

namespace CopaFilmes.CrossCutting
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            //App
            container.Register<IFilmeAppService, FilmeAppService>(Lifestyle.Scoped);
            container.Register<ICampeonatoAppService, CampeonatoAppService>(Lifestyle.Scoped);

            //Domain
            container.Register<IFilmeService, FilmeService>(Lifestyle.Scoped);
            container.Register<ICampeonatoService, CampeonatoService>(Lifestyle.Scoped);

            //Data
            container.Register<IFilmeApiService, FilmeApiService>(Lifestyle.Scoped);
        }
    }
}
