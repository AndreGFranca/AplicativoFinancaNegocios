using DTO.Enums;
using DTO.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Salario
{
    public class DeleteSalarioDTO:BaseUpdateDTO
    {
        public decimal CustoTotal { get; set; }
        public int TempoDeProducaoPorMinuto { get; set; }
        public int DiasNoMes { get; set; }
        public int DiasPorSemana { get; set; }
        public int HorasPorDia { get; set; }
    }
}
