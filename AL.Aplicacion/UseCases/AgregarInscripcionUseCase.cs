namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class AgregarInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public AgregarInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion=rInscripcion;
    }
    public void Ejecutar(Inscripcion i){
        _rInscripcion.AgregarInscripcion(i);
    }
}