using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PORTALFABIA.Models
{
      [Table("t_matriculadosFab")]
    public class RegistroFab
    {
    [Key]
    [Required]
    public string? numMatricula { get; set; }

    [Required]
    public string? Apellidos { get; set; }

    [Required]
    public string? Nombre { get; set; }



    [Required]
    public string? Correo { get; set; }

    [Required]
    public int Edad { get; set; }

    [Required]
    public string? Distrito { get; set; }
    
    [Required]
    public string? Semana { get; set; }
    
    [Required]
    public string? Horario { get; set; }

   
    }
}