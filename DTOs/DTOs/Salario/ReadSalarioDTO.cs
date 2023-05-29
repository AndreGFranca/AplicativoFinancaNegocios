using DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Salario
{
    public class ReadSalarioDTO
    {
        public int Id { get; set; }
        public decimal CustoTotal { get; set; }
        public int TempoDeProducaoPorMinuto { get; set; }        
        public int DiasNoMes { get; set; }
        public int DiasPorSemana { get; set; }
        public int HorasPorDia { get; set; }
        public DateTime DataRegistro { get; set; }
        public decimal ValorPorDia { get { return CustoTotal / DiasNoMes; } }
        public decimal ValorPorHora { get { return ValorPorDia / HorasPorDia; } }
        public decimal ValorPorMinutos { get { return ValorPorHora / TempoDeProducaoPorMinuto; } }
        public decimal CustoMaoObra { get { return ValorPorMinutos * TempoDeProducaoPorMinuto; } }
    }
}
