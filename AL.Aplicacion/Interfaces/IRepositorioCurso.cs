namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
public interface IRepositorioCurso{
    Curso? GetCurso(int id);
    void ModificarCurso(Curso c);
    void EliminarCurso(int id);
    void AgregarCurso(Curso c);
    List<Curso> Listar();
}