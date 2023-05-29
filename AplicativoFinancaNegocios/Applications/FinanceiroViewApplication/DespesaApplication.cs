using AplicativoFinancaNegocios.Services;
using DTO.Models.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.FinanceiroViewApplication
{
    public class DespesaApplication : BaseApplication<Financeiro>, IBaseApplication
    {
        public DespesaApplication(IConsolidarBanco context, IBaseService<Financeiro> baseService) : base(context, baseService)
        {
        }
    }
}
