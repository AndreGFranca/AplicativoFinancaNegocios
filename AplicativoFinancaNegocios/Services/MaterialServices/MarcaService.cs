using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.MaterialServices
{
    public class MarcaService : BaseService<Marca>, IBaseService<Marca>
    {
        public MarcaService(IMapper mapper, IBaseRepository<Marca> context) : base(mapper, context)
        {
        }
    }
}
