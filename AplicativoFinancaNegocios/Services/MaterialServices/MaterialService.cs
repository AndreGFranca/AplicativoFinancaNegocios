using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Materiais;
using DTO.DTOs.Salario;
using DTO.Models.Materiais;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.MaterialServices
{
    public class MaterialService : BaseService<Material>, IBaseService<Material>
    {
        public MaterialService(IMapper mapper, IBaseRepository<Material> context) : base(mapper, context)
        {
        }
    }
}
