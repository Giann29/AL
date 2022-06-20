namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ModificarEstudianteUseCase{
    private readonly IRepositorioEstudiante _rEstudiante;
    public ModificarEstudianteUseCase(IRepositorioEstudiante rEstudiante){
        _rEstudiante=rEstudiante;
    }
    public void Ejecutar(Estudiante e){
        _rEstudiante.ModificarEstudiante(e);
    }
}