using AplicativoFinancaNegocios.Services;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.MaterialViewApplication
{
    public class MarcaApplication : BaseApplication<Marca>, IBaseApplication
    {
        public MarcaApplication(IConsolidarBanco context, IBaseService<Marca> baseService) : base(context, baseService)
        {
        }
    }
}
