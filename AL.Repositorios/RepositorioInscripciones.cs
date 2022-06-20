namespace AL.Repositorios;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using AL.Repositorios.Context;
public class RepositorioInscripciones : IRepositorioInscripcion
{
    private RepositorioContext context = new RepositorioContext();
    public Inscripcion GetInscripcion(int id)
    {
        var get = context.Inscripciones.Where(x => x.Id == id).SingleOrDefault();
        Inscripcion i = new Inscripcion();
        if (get != null)
        {
            i.Fecha = get.Fecha;
            i.Id = get.Id;
            i.IdCurso = get.IdCurso;
            i.IdEstudiante = get.IdEstudiante;
        }
        return i;
    }
    public void ModificarInscripcion(Inscripcion i)
    {
        var modificar = context.Inscripciones.Where(x => (x.IdEstudiante == i.IdEstudiante) && (x.IdCurso == i.IdCurso)).SingleOrDefault();
        if (modificar != null)
        {
            modificar.Fecha = i.Fecha;
            modificar.IdCurso = i.IdCurso;
            modificar.IdEstudiante = i.IdEstudiante;
        }
        context.SaveChanges();
    }
    public void EliminarInscripcion(int id)
    {
        var eliminar = context.Inscripciones.Where(x => x.Id == id).SingleOrDefault();
        if (eliminar != null)
        {
            context.Remove(eliminar);
        }
        context.SaveChanges();
    }
    public void AgregarInscripcion(Inscripcion i)
    {
        var agregar = context.Inscripciones.Where(x => (x.IdEstudiante == i.IdEstudiante) && (x.IdCurso == i.IdCurso)).SingleOrDefault();
        if (agregar == null)
        {
            context.Add(i);
            context.SaveChanges();
        }
    }
    public bool estaInscripto(Inscripcion i)
    {
        var esta = context.Inscripciones.Where(x => (x.IdEstudiante == i.IdEstudiante) && (x.IdCurso == i.IdCurso)).SingleOrDefault();
        if (esta == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public Inscripcion? Buscar(int idE, int idC)
    {
        var esta = context.Inscripciones.Where(x => (x.IdEstudiante == idE) && (x.IdCurso == idC)).SingleOrDefault();
        if (esta != null)
        {
            return esta;
        }
        else
        {
            return null;
        }
    }
    public List<Inscripcion> Listar()
    {
        return context.Inscripciones.ToList();
    }
}