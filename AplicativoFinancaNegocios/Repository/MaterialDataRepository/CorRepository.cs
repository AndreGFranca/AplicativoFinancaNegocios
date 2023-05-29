using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Estoque;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.MaterialDataRepository
{
    public class CorRepository : BaseRepository<Cor>, IBaseRepository<Cor>
    {
        public CorRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
