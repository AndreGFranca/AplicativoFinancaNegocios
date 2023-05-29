using DTO.DTOs.Materiais.Cor;
using DTO.DTOs.Materiais.MarcaDTOs;
using DTO.DTOs.Materiais.UnidadeDeMedidaDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.MaterialConfig
{
    public class ReadMaterialConfigDTO
    {
        public IReadOnlyList<ReadCorDTO> Cores { get; set; }
        public IReadOnlyList<ReadMarcaDTO> Marcas { get; set; }
        public IReadOnlyList<ReadUnidadeDeMedidaDTO> UnidadesDeMedida { get; set; }
    }
}
