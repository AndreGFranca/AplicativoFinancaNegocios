using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.ModelBase
{
    public class ModeloBase:Auditoria
    {
        [Key]
        [Required]
        public int Id { get; set; }
    }
}
