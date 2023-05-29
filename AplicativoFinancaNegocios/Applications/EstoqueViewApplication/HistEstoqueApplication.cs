using AplicativoFinancaNegocios.Services;
using DTO.Models.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.EstoqueViewApplication
{
    internal class HistEstoqueApplication : BaseApplication<HistoricoEstoque>, IBaseApplication
    {
        public HistEstoqueApplication(IConsolidarBanco context, IBaseService<HistoricoEstoque> baseService) : base(context, baseService)
        {
        }
    }
}
