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
    public class CreateMaterialConfigDTO
    {
        public CreateCorDTO? Cor { get; set; }
        public CreateMarcaDTO? Marca { get; set; }
        public CreateUnidadeDeMedidaDTO? UnidadeDeMedida { get; set; }

    }
}
