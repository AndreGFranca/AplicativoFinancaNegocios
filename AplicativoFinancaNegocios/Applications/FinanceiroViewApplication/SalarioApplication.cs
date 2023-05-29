using AplicativoFinancaNegocios.Services;
using DTO.Models.Financeiro;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.FinanceiroViewApplication
{
    public class SalarioApplication : BaseApplication<Financeiro>, IBaseApplication
    {
        public SalarioApplication(IConsolidarBanco context, IBaseService<Financeiro> baseService) : base(context, baseService)
        {
        }
    }
}
