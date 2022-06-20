namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class EliminarCursoUseCase{
    private readonly IRepositorioCurso _rCurso;
    public EliminarCursoUseCase(IRepositorioCurso rCurso){
        _rCurso=rCurso;
    }
    public void Ejecutar(int id){
        _rCurso.EliminarCurso(id);
    }
}