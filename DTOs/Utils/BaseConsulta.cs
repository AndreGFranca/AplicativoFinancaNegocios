using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Utils
{
    public class BaseConsulta
    {
        public int? PaginaAtual { get; set; }
        public int? ProximaPagina { get; set; }
        public int? PaginaAnterior { get; set; }
        public int? QuantidadePorPagina { get; set; }
        public int? Total { get; set; }
        public int? PageNum { get; set; }
    }
}
