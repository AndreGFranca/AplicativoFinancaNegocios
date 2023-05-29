using DTO.Models.ModelBase;
using System.ComponentModel.DataAnnotations;

namespace DTO.Models.Produtos
{
    public class Produto : ModeloBase
    {
        [Required(ErrorMessage = "O campo o Nome não pode ser enviado em branco.")]
        [MaxLength(255, ErrorMessage = "Tamanho do Nome maior do que o permitido, limite = 255")]
        public string Nome { get; set; }
        [Required]
        public decimal LucroPorcentagem { get; set; }
        public IEnumerable<ProdutoComposicao>? ComposicoesDoProduto { get; set; }
        public IEnumerable<Imagem.Imagem>? Imagens { get; set; }
        [Required]
        public string Descricao { get; set; }
        public decimal? ValorAnunciado { get; set; }
    }
}