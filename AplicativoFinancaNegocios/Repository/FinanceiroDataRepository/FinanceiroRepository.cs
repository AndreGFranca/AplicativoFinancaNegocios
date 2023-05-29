using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Estoque;
using DTO.Models.Financeiro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.FinanceiroDataRepository
{
    public class FinanceiroRepository : BaseRepository<Financeiro>, IBaseRepository<Financeiro>
    {
        public FinanceiroRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
