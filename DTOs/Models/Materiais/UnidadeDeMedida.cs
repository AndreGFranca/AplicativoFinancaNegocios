using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.Materiais
{
    public class UnidadeDeMedida : ModeloBase
    {
        [Required]
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
    }
}
