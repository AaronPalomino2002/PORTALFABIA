using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PORTALFABIA.Models
{
    [Table("t_alumnos")]
    public class Alumno
{
    public int Id { get; set; }
    public string? NumMatricula { get; set; }
    public string? Nombre { get; set; }
    public string? ApePat { get; set; }
    public string? ApeMat { get; set; }
    public string? Correo { get; set; }
    public int Edad { get; set; }
    public string? Celular { get; set; }
    public long CarreraId { get; set; }
    public Carrera? Carrera { get; set; }
    public Login? Login { get; set; } // Relación con la tabla Login
}

}
