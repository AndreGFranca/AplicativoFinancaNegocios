using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.ModelBase
{
    public class Auditoria
    {
        public DateTime DataAuditoriaRegistro { get; set; }
        [Required]
        public DateTime DataRegistro { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}
