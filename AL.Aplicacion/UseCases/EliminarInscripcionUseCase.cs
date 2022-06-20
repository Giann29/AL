namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class EliminarInscripcionUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public EliminarInscripcionUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion=rInscripcion;
    }
    public void Ejecutar(int id){
        _rInscripcion.EliminarInscripcion(id);
    }
}