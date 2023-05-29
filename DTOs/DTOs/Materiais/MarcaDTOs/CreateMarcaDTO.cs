using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.MarcaDTOs
{
    public class CreateMarcaDTO
    {
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Quantidades de caracteres deve estar entre 1 e 250")]
        public string Nome { get; set; }
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
    }
}
