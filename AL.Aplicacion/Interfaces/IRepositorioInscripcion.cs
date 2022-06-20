namespace AL.Aplicacion.Interfaces;
using AL.Aplicacion.Entidades;
public interface IRepositorioInscripcion{
    
    Inscripcion GetInscripcion(int id);
    void ModificarInscripcion(Inscripcion i);
    void EliminarInscripcion(int id);
    void AgregarInscripcion(Inscripcion i);
    bool estaInscripto(Inscripcion i);
    Inscripcion? Buscar(int idE,int idC);
    List<Inscripcion> Listar();
}