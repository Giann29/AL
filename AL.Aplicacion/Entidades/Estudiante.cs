namespace AL.Aplicacion.Entidades;
using System.ComponentModel.DataAnnotations;
public class Estudiante
{
    public int Id { get; set; }
    [Required]
    public int DNI { get; set; }
    [Required]
    public string? Nombre { get; set; }
    [Required]
    public string? Apellido { get; set; }
    [Required]
    public string? Email { get; set; }
}