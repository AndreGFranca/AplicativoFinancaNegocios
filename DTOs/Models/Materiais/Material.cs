using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.Materiais
{
    public class Material : ModeloBase
    {
        [Required]
        [StringLength(250,MinimumLength = 1)]
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        [Required]
        public decimal PrecoPadrao { get; set; }
        [Required]
        public double PesoEmbalagem { get; set; }
        [Required]
        public double PesoQTDOriginal { get; set; }
        [Required]
        public int UnidadeDeMedidaId { get; set; }
        public virtual UnidadeDeMedida UnidadeDeMedida { get; set; }

    }
}
