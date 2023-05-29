using AplicativoFinancaNegocios.Services;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.MaterialViewApplication
{
    public class UnidadeDeMedidaApplication : BaseApplication<UnidadeDeMedida>, IBaseApplication
    {
        public UnidadeDeMedidaApplication(IConsolidarBanco context, IBaseService<UnidadeDeMedida> baseService) : base(context, baseService)
        {
        }
    }
}
