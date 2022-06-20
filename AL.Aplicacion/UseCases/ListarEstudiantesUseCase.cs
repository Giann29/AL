namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ListarEstudiantesUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    public ListarEstudiantesUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante=rEstudiante;
    }
    public List<Estudiante> Ejecutar(){
        return _rEstudiante.Listar();
    }
}