namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class GetEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    public GetEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante=rEstudiante;
    }
    public Estudiante? Ejecutar(int id){
        return _rEstudiante.GetEstudiante(id);
    }
}