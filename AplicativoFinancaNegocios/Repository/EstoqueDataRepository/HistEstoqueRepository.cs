using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Estoque;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.EstoqueDataRepository
{
    public class HistEstoqueRepository : BaseRepository<HistoricoEstoque>, IBaseRepository<HistoricoEstoque>
    {
        public HistEstoqueRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
