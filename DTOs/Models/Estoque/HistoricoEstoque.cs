using DTO.Enums;
using DTO.Models.Materiais;
using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.Estoque
{
    public class HistoricoEstoque : ModeloBase
    {
        [Required]
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int? CorId { get; set; }
        public virtual Cor Cor { get; set; }
        public int? MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        public TipoOperacao Operacao { get; set; }

        [Required]
        public int Quantidade { get; set; }
        [Required]
        public decimal PrecoPago { get; set; }

    }
}
