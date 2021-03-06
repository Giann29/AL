namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class GetCursoUseCase{
    private readonly IRepositorioCurso _rCurso;
    public GetCursoUseCase(IRepositorioCurso rCurso){
        _rCurso=rCurso;
    }
    public Curso? Ejecutar(int id){
        return _rCurso.GetCurso(id);
    }
}