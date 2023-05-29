using AplicativoFinancaNegocios.Services;
using DTO.Models.Materiais;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.MaterialViewApplication
{
    public class CorApplication : BaseApplication<Cor>, IBaseApplication
    {
        public CorApplication(IConsolidarBanco context, IBaseService<Cor> baseService) : base(context, baseService)
        {
        }
    }
}
