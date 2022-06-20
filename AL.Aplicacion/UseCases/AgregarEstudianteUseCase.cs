namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class AgregarEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    public AgregarEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante=rEstudiante;
    }
    public void Ejecutar(Estudiante e){
        _rEstudiante.AgregarEstudiante(e);
    }
}