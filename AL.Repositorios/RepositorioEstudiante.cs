namespace AL.Repositorios;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using AL.Repositorios.Context;
public class RepositorioEstudiante: IRepositorioEstudiante{
    private RepositorioContext context= new RepositorioContext();
    public Estudiante GetEstudiante(int id){
        var get=context.Estudiantes.Where(x=>x.Id==id).SingleOrDefault();
        Estudiante e=new Estudiante();
        if (get != null){
            e.Apellido=get.Apellido;
            e.Nombre=get.Nombre;
            e.DNI=get.DNI;
            e.Email=get.Email;
            e.Id=get.Id;
        }
        return e;
    }
    public void ModificarEstudiante(Estudiante e){
        var modificar= context.Estudiantes.Where(x=>x.Id==e.Id).SingleOrDefault();
        if (modificar!=null){
            modificar.Apellido=e.Apellido;
            modificar.DNI=e.DNI;
            modificar.Email=e.Email;
            modificar.Nombre=e.Nombre;
        }
        context.SaveChanges();
    }
    public void EliminarEstudiante(int id){
        var eliminar=context.Estudiantes.Where(x=>x.Id==id).SingleOrDefault();
        if (eliminar!=null){
            context.Remove(eliminar);
        }
        context.SaveChanges();
    }
    public void AgregarEstudiante(Estudiante e){
        if(context.Estudiantes.Where(x=>x.DNI==e.DNI).SingleOrDefault()==null){
            context.Add(e);
            context.SaveChanges();
        }
        else{
            throw new Exception(message:"Ya existe este estudiante");
        }
    }
    public List<Estudiante> Listar(){
        return context.Estudiantes.ToList();
    }
}