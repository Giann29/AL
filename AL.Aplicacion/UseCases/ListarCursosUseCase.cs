namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ListarCursosUseCase{
    private readonly IRepositorioCurso _rCurso;
    public ListarCursosUseCase(IRepositorioCurso rCurso){
        _rCurso=rCurso;
    }
    public List<Curso> Ejecutar(){
        return _rCurso.Listar();
    }
}