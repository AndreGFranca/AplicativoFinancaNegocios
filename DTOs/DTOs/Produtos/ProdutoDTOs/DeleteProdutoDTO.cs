using DTO.DTOs.Imagem;
using DTO.Models.Produtos;
using DTO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Produtos.ProdutoDTOs
{
    public class DeleteProdutoDTO:BaseUpdateDTO
    {
        public string Nome { get; set; }
        public decimal LucroPorcentagem { get; set; }
        public IEnumerable<ProdutoComposicao>? ComposicoesDoProduto { get; set; }
        public IEnumerable<ReadImagemDTO>? Imagens { get; set; }
        public string Descricao { get; set; }
        public decimal? ValorAnunciado { get; set; }
        [Required]
        public DateTime DataRegistro { get; set; }
    }
}
