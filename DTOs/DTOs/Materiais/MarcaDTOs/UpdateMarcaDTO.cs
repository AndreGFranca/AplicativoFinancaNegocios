using DTO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Materiais.MarcaDTOs
{
    public class UpdateMarcaDTO : BaseUpdateDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
