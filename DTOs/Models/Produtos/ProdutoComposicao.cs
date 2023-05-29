using DTO.Models.Materiais;
using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.Produtos
{
    public class ProdutoComposicao : Auditoria
    {
        [Key]
        [Required]
        public int ProdutoId { get; set; }
        [Key]
        [Required]
        public int MaterialId { get; set; }
        public double Quantidade { get; set; }
        public virtual Material Material { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
