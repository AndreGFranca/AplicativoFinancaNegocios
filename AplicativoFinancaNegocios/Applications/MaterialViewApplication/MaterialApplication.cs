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
    public class MaterialApplication : BaseApplication<Material>, IBaseApplication
    {
        public MaterialApplication(IConsolidarBanco context, IBaseService<Material> baseService) : base(context, baseService)
        {
        }
    }
}
