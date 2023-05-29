using DTO.Enums;
using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Models.Financeiro
{
    public class Financeiro : ModeloBase
    {
        [Required]
        public decimal CustoTotal { get; set; }
        [Required]
        public int TempoDeProducaoPorMinuto { get; set; }
        [Required]
        public int DiasNoMes { get; set; }
        [Required]
        public int DiasPorSemana { get; set; }
        [Required]
        public int HorasPorDia { get; set; }
        [Required]
        public TipoTransacaoFinanceira TipoTransacaoFinanceira { get; set; }
    }
}
