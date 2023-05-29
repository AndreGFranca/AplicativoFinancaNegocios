using DTO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.UnidadeDeMedidaDTOs
{
    public class FilterUnidadeDeMedidaDTO: BaseFiltroDTO
    {
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
    }
}
