using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.MaterialDTOs
{
    public class CreateMaterialDTO
    {
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [StringLength(250, MinimumLength = 1)]
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(0.01, double.PositiveInfinity, ErrorMessage = "O valor deve estar acima 0.01")]
        public decimal PrecoPadrao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(0.0001, double.PositiveInfinity, ErrorMessage = "O valor deve estar acima 0.0001")]
        public double PesoEmbalagem { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório.")]
        [Range(0.0001, double.PositiveInfinity, ErrorMessage = "O valor deve estar acima 0.0001")]
        public double PesoQTDOriginal { get; set; }
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "O Campo Unidade De Medida é Obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor não pode ser vazio")]
        public int UnidadeDeMedidaId { get; set; }
    }
}
