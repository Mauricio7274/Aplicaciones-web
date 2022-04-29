using Microsoft.EntityFrameworkCore;
using WebApplication1.Datos.Modelo;

namespace WebApplication1.Datos.Servicio
{
    public class Repositoriodebiblioteca
    {
        public class RepositorioBiblioteca : DbContext
        {
            public RepositorioBiblioteca(DbContextOptions<RepositorioBiblioteca> options) : base(options)
            {

            }
            public DbSet<Libro> Libros { get; set; }
            //Crear otras 3 propiedades restantes (Autor, Estudiante, Préstamo)
        }
    }
}
    

