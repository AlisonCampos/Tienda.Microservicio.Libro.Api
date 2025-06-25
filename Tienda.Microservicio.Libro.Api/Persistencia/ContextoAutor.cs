using Microsoft.EntityFrameworkCore;
using Tienda.Microservicio.Libro.Api.Modelo;

namespace Tienda.Microservicio.Libro.Api.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options)
        {
        }

        public DbSet<AutorLibro> AutorLibros { get; set; }
        public DbSet<GradoAcademico> GradoAcademicos { get; set; }
    }
}