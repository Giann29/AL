namespace AL.Aplicacion.Entidades;
using System.ComponentModel.DataAnnotations;
public class Curso
{
    public int Id { get; set; }
    [Required]
    public string? Titulo { get; set; }
    [Required]
    public string? Descripcion { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
}