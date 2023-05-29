using DTO.Models.ModelBase;
using DTO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Imagem
{
    public class UpdateImagemDTO: BaseUpdateDTO
    {
        [Required]
        public string NomeDoArquivo { get; set; }
        [Required]
        public byte[] BytesDaImagem { get; set; }
        public string Imagem64 { get; set; }
    }
}
