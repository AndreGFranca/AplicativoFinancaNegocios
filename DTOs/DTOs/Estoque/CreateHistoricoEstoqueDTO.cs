using DTO.Enums;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Estoque
{
    public class CreateHistoricoEstoqueDTO
    {
        [Required(ErrorMessage ="Material é necessário")]
        public int? MaterialId { get; set; }
        public int? CorId { get; set; }
        public int? MarcaId { get; set; }
        [Required(ErrorMessage ="É necessário escolher um tipo de operação")]        
        public TipoOperacao Operacao { get; set; }
        [Required]
        [Range(1,double.PositiveInfinity, ErrorMessage = "Valor deve estar acima de 0")]
        public int Quantidade { get; set; }        
        [Required]
        [Range(1, double.PositiveInfinity, ErrorMessage = "Valor deve estar acima de 0")]
        public decimal? PrecoPago { get; set; }
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
    }
}
