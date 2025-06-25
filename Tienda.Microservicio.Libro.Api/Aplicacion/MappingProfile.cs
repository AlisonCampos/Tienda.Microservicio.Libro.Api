using AutoMapper;
using Tienda.Microservicio.Libro.Api.Modelo;


namespace Tienda.Microservicio.Libro.Api.Aplicacion
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }
    }
}