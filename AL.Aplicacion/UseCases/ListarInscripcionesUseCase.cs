namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ListarInscripcionesUseCase{
    private readonly IRepositorioInscripcion _rInscripcion;
    public ListarInscripcionesUseCase(IRepositorioInscripcion rInscripcion){
        _rInscripcion=rInscripcion;
    }
    public List<Inscripcion> Ejecutar(){
        return _rInscripcion.Listar();
    }
}