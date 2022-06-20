namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ModificarInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ModificarInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion=rInscripcion;
    }
    public void Ejecutar(Inscripcion i){
        _rInscripcion.ModificarInscripcion(i);
    }
}