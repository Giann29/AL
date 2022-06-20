namespace AL.Repositorios;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using AL.Repositorios.Context;
public class RepositorioCurso : IRepositorioCurso
{
    private RepositorioContext context = new RepositorioContext();
    public Curso GetCurso(int id)
    {
        var get = context.Cursos.Where(x => x.Id == id).SingleOrDefault();
        Curso c = new Curso();
        if (get != null)
        {
            c.Titulo = get.Titulo;
            c.Descripcion = get.Descripcion;
            c.FechaFinalizacion = get.FechaFinalizacion;
            c.FechaInicio = get.FechaInicio;
            c.Id = get.Id;
        }
        return c;
    }
    public void ModificarCurso(Curso c)
    {
        var modificar = context.Cursos.Where(x => x.Id == c.Id).SingleOrDefault();
        if (modificar != null)
        {
            modificar.Descripcion = c.Descripcion;
            modificar.FechaFinalizacion = c.FechaFinalizacion;
            modificar.FechaInicio = c.FechaInicio;
            modificar.Titulo = c.Titulo;
        }
        context.SaveChanges();
    }
    public void EliminarCurso(int id)
    {
        var eliminar = context.Cursos.Where(x => x.Id == id).SingleOrDefault();
        if (eliminar != null)
        {
            context.Remove(eliminar);
        }
        context.SaveChanges();
    }
    public void AgregarCurso(Curso c)
    {
        var agregar = context.Cursos.Where(x => x.Titulo.Equals(c.Titulo)).SingleOrDefault();
        if (agregar == null)
        {
            context.Add(c);
            context.SaveChanges();
        }
        else
        {
            throw new Exception(message: "Ya existe este curso");
        }
    }
    public List<Curso> Listar()
    {
        return context.Cursos.ToList();
    }
}