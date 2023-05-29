using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.UnidadeDeMedidaDTOs
{
    public class ReadUnidadeDeMedidaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
