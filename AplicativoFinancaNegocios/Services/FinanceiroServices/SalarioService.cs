using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Despesa;
using DTO.DTOs.Salario;
using DTO.Enums;
using DTO.Models.Financeiro;
using DTO.Models.Produtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.SalarioServices
{
    public class SalarioService : BaseService<Financeiro>
    {
        public SalarioService(IMapper mapper, IBaseRepository<Financeiro> context) : base(mapper, context)
        {
        }
    }
}
