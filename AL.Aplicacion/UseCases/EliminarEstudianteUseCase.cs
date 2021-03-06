namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class EliminarEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    public EliminarEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante=rEstudiante;
    }
    public void Ejecutar(int id){
        _rEstudiante.EliminarEstudiante(id);
    }
}