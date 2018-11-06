using AutoMapper;
using CopaFilmes.Application.ViewModel;
using CopaFilmes.Domain.Entities;

namespace CopaFilmes.Application.AutoMapper
{
    class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile() : base()
        {
            CreateMap<FilmeViewModel, Filme>();
        }
    }
}
