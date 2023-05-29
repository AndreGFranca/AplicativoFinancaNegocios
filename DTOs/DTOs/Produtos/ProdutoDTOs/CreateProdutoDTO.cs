using img = DTO.Models.Imagem;
using DTO.Models.Materiais;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.DTOs.Imagem;

namespace DTO.DTOs.Produtos.ProdutoDTOs
{
    public class CreateProdutoDTO
    {
        public CreateProdutoDTO()
        {
            ComposicoesDoProduto = new List<ProdutoComposicao>();
            Imagens = new List<CreateImagemDTO>();
        }
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
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
    }
}
