using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PORTALFABIA.Models
{
    [Table("t_login")]
    public class Login
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set;}
        public string? Correo {get; set;}
        public string? Password {get; set;}
    }
}