using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.MaterialServices
{
    public class UnidadeDeMedidaService : BaseService<UnidadeDeMedida>, IBaseService<UnidadeDeMedida>
    {
        public UnidadeDeMedidaService(IMapper mapper, IBaseRepository<UnidadeDeMedida> context) : base(mapper, context)
        {
        }
    }
}
