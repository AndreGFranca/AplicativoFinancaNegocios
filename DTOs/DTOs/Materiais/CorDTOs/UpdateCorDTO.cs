using DTO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.CorDTOs
{
    public class UpdateCorDTO : BaseUpdateDTO
    {
        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [StringLength(250, MinimumLength = 1, ErrorMessage = "Quantidades de caracteres deve estar entre 1 e 250")]
        public string Nome { get; set; }
    }
}
