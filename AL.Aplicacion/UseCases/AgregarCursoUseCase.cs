namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class AgregarCursoUseCase{
    private readonly IRepositorioCurso _rCurso;
    public AgregarCursoUseCase(IRepositorioCurso rCurso){
        _rCurso=rCurso;
    }
    public void Ejecutar(Curso c){
        _rCurso.AgregarCurso(c);
    }
}