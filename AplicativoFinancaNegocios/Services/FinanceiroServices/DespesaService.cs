using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Despesa;
using DTO.DTOs.Salario;
using DTO.Enums;
using DTO.Models.Financeiro;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.FinanceiroServices
{
    public class DespesaService : BaseService<Financeiro>, IBaseService<Financeiro>
    {
        public DespesaService(IMapper mapper, IBaseRepository<Financeiro> context) : base(mapper, context)
        {
        }
    }
}
