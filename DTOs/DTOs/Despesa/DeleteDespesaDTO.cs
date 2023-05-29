using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Despesa
{
    public class DeleteDespesaDTO
    {
        public int Id { get; set; }
        public decimal CustoTotal { get; set; }
        public int TempoDeProducaoPorMinuto { get; set; }
        public int DiasNoMes { get; set; }
        public int DiasPorSemana { get; set; }
        public int HorasPorDia { get; set; }
    }
}
