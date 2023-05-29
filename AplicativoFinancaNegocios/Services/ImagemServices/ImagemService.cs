using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Imagem;
using DTO.DTOs.Materiais;
using DTO.Models.Imagem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.ImagemServices
{
    public class ImagemService : BaseService<Imagem>, IBaseService<Imagem>
    {
        public ImagemService(IMapper mapper, IBaseRepository<Imagem> context) : base(mapper, context)
        {
        }
    }
}
