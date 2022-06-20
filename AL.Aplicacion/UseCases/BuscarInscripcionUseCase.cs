namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class BuscarInscripcionUseCase
{
    private readonly IRepositorioInscripcion _rInscripcion;
    public BuscarInscripcionUseCase(IRepositorioInscripcion rInscripcion)
    {
        _rInscripcion = rInscripcion;
    }
    public Inscripcion? Ejecutar(int idE, int idC)
    {
        return _rInscripcion.Buscar(idE, idC);
    }
}