using Microsoft.EntityFrameworkCore;
using AL.Aplicacion.Entidades;
namespace AL.Repositorios.Context;

public class RepositorioContext : DbContext
{
    #nullable disable
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Inscripcion> Inscripciones { get; set; }
    #nullable restore

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlite("data source=Repositorio.sqlite");
}
}