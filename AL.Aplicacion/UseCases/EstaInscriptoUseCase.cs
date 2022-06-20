namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class EstaInscriptoUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public EstaInscriptoUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion=rInscripcion;
    }
    public bool Ejecutar(Inscripcion i){
        return _rInscripcion.estaInscripto(i);
    }
}