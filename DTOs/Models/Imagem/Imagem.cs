using DTO.Models.ModelBase;
using System.ComponentModel.DataAnnotations;

namespace DTO.Models.Imagem
{
    public class Imagem : ModeloBase
    {
        [Required]
        public string NomeDoArquivo { get; set; }
        [Required]
        public byte[] BytesDaImagem { get; set; }
    }
}
