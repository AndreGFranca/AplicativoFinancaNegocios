using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Utils
{
    public class BaseUpdateDTO
    {
        public DateTime DataAuditoriaRegistro { get; set; } = DateTime.Now;
        public bool Ativo { get; set; } = true;
    }
}
