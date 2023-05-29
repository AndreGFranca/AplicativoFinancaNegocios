using DTO.Models.Materiais;
using DTO.Models.Produtos;

namespace DTO.DTOs.Produtos.ComposicaoProduto
{
    public class ReadProdutoComposicaoDTO
    {
        public int ProdutoId { get; set; }
        public int MaterialId { get; set; }
        public double Quantidade { get; set; }
        public virtual Material Material { get; set; }
        public virtual Produto Produto { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
