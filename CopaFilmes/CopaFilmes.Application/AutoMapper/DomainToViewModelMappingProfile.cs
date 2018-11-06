using AutoMapper;
using CopaFilmes.Application.ViewModel;
using CopaFilmes.Domain.Entities;

namespace CopaFilmes.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() : base()
        {
            CreateMap<Filme, FilmeViewModel>();
        }
    }
}
