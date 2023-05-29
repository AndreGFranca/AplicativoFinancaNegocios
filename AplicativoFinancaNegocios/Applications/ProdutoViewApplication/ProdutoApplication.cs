using AplicativoFinancaNegocios.Services;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications.ProdutoViewApplication
{
    public class ProdutoApplication : BaseApplication<Produto>, IBaseApplication
    {
        public ProdutoApplication(IConsolidarBanco context, IBaseService<Produto> baseService) : base(context, baseService)
        {
        }
    }
}
