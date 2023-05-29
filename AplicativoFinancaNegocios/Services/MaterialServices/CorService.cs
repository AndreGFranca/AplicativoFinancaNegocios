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
    public class CorService : BaseService<Cor>, IBaseService<Cor>
    {
        public CorService(IMapper mapper, IBaseRepository<Cor> context) : base(mapper, context)
        {
        }
    }
}
