using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.MaterialDataRepository
{
    public class MarcaRepository : BaseRepository<Marca>, IBaseRepository<Marca>
    {
        public MarcaRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
