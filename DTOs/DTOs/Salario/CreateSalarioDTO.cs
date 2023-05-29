using DTO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOs.Salario
{
    public class CreateSalarioDTO
    {
        [Required(ErrorMessage = "definir o Salário desejado para o calculo é Obrigatório.")]
        [Range(0.01, Double.PositiveInfinity, ErrorMessage = "Valor deve ser acima de 0.01")]
        public decimal CustoTotal { get; set; }

        [Required(ErrorMessage = "definir o tempo de Produção por Minuto é Obrigatório.")]
        [Range(1, int.MaxValue, ErrorMessage = "Valor deve ser acima de 1")]
        public int TempoDeProducaoPorMinuto { get; set; }
        [Required(ErrorMessage = "definir a quantidade de Dias que deseja trabalhar no Mês é Obrigatório.")]
        [Range(1, 30, ErrorMessage = "Valor deve estar entre 1 e 30")]
        public int DiasNoMes { get; set; }
        [Required(ErrorMessage = "definir a quantidade de Dias que deseja trabalhar por Semana é Obrigatório.")]
        [Range(1, 7, ErrorMessage = "Valor deve estar entre 1 e 7")]
        public int DiasPorSemana { get; set; }
        [Required(ErrorMessage = "definir a quantidade de Horas que deseja trabalhar por dia é Obrigatório.")]
        [Range(1, 24, ErrorMessage = "Valor deve estar entre 1 e 24")]
        public int HorasPorDia { get; set; }
        [Required]
        public bool Ativo { get; set; } = true;
        [Required]
        public DateTime DataRegistro { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "O tipo de operação Financeira é Obrigatória.")]
        public TipoTransacaoFinanceira Financeiro { get; set; } = TipoTransacaoFinanceira.Receita;
    }
}
