using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.MaterialDataRepository
{
    public class UnidadeDeMedidaRepository : BaseRepository<UnidadeDeMedida>, IBaseRepository<UnidadeDeMedida>
    {
        public UnidadeDeMedidaRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
