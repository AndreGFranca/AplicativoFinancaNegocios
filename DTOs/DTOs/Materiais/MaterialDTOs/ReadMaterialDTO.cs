using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.MaterialDTOs
{
    public class ReadMaterialDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoPadrao { get; set; }
        public double PesoEmbalagem { get; set; }
        public double PesoQTDOriginal { get; set; }
        public int UnidadeDeMedidaId { get; set; }
        public virtual UnidadeDeMedida UnidadeDeMedida { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
