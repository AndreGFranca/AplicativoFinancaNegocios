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
    public class ReadHistoricoEstoqueDTO
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public virtual Material Material { get; set; }
        public int? CorId { get; set; }
        public virtual Cor Cor { get; set; }
        public int? MarcaId { get; set; }
        public virtual Marca Marca { get; set; }        
        public TipoOperacao Operacao { get; set; }        
        public int Quantidade { get; set; }
        public DateTime DataRegistro { get; set; }
        public decimal PrecoPago { get; set; }                
    }
}
