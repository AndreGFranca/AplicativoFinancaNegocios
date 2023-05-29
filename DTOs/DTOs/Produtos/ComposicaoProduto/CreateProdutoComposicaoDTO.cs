using DTO.Models.Produtos;
using DTO.Models.Materiais;
using System.ComponentModel.DataAnnotations;

namespace DTO.DTOs.Produtos.ComposicaoProduto
{
    public class CreateProdutoComposicaoDTO
    {
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int MaterialId { get; set; }
        public double Quantidade { get; set; }
        public virtual Material Material { get; set; }
        public virtual Produto Produto { get; set; }
        public bool Ativo { get; set; } = true;
        public DateTime DataRegistro { get; set; } = DateTime.Now;
    }
}
