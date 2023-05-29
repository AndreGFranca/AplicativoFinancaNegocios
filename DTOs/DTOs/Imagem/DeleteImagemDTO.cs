using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Imagem
{
    public class DeleteImagemDTO
    {
        public int Id { get; set; }
        [Required]
        public string NomeDoArquivo { get; set; }
        [Required]
        public byte[] BytesDaImagem { get; set; }
    }
}
