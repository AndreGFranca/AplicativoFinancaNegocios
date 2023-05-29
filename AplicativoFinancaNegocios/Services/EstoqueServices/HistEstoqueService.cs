using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Estoque;
using DTO.DTOs.Materiais;
using DTO.Models.Estoque;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.EstoqueServices
{
    public class HistEstoqueService : BaseService<HistoricoEstoque>, IBaseService<HistoricoEstoque>
    {
        public HistEstoqueService(IMapper mapper, IBaseRepository<HistoricoEstoque> context) : base(mapper, context)
        {
        }
    }
}
