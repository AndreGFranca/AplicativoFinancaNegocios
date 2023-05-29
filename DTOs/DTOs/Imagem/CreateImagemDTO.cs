using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Imagem
{
    public class CreateImagemDTO
    {
        public CreateImagemDTO()
        {
            
        }
        public CreateImagemDTO(CreateImagemDTO novaImagem)
        {
            NomeDoArquivo = novaImagem.NomeDoArquivo;
            BytesDaImagem = novaImagem.BytesDaImagem;
            Imagem64 = novaImagem.Imagem64;
        }
        [Required]
        public string NomeDoArquivo { get; set; }
        [Required]
        public byte[] BytesDaImagem { get; set; }
        public string Imagem64 { get; set; }
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
    }
}
