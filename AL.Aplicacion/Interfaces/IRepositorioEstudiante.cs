namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
public interface IRepositorioEstudiante{
    Estudiante GetEstudiante(int id);
    void ModificarEstudiante(Estudiante e);
    void EliminarEstudiante(int id);
    void AgregarEstudiante(Estudiante e);
    List<Estudiante> Listar();
}