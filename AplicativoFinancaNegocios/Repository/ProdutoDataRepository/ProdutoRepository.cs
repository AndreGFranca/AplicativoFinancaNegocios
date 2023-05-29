using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.ProdutoDataRepository
{
    public class ProdutoRepository : BaseRepository<Produto>, IBaseRepository<Produto>
    {
        public ProdutoRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
