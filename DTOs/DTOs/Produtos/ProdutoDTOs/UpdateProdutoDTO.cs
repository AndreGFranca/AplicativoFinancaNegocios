using DTO.DTOs.Imagem;
using DTO.Models.Produtos;
using DTO.Utils;
using System.ComponentModel.DataAnnotations;


namespace DTO.DTOs.Produtos.ProdutoDTOs
{
    public class UpdateProdutoDTO: BaseUpdateDTO
    {
        [Required(ErrorMessage = "O campo o Nome não pode ser enviado em branco.")]
        [MaxLength(255, ErrorMessage = "Tamanho do Nome maior do que o permitido, limite = 255")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O Campo de Porcentagem de Lucro é Obrigatório")]
        [Range(0, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero.")]
        public decimal LucroPorcentagem { get; set; }
        public IList<ProdutoComposicao>? ComposicoesDoProduto { get; set; }
        public IList<CreateImagemDTO>? Imagens { get; set; }
        [Required(ErrorMessage = "O campo o Descrição não pode ser enviado em branco.")]
        [MaxLength(1000, ErrorMessage = "Tamanho da Descrição maior do que o permitido, limite = 1000")]
        public string Descricao { get; set; }
        public decimal? ValorAnunciado { get; set; }
    }
}
