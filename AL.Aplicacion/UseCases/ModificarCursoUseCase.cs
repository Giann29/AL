namespace AL.Aplicacion.UseCases;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
public class ModificarCursoUseCase{
    private readonly IRepositorioCurso _rCurso;
    public ModificarCursoUseCase(IRepositorioCurso rCurso){
        _rCurso=rCurso;
    }
    public void Ejecutar(Curso c){
        _rCurso.ModificarCurso(c);
    }
}