using AplicativoFinancaNegocios.DataBase;
using DTO.Models.Imagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Repository.ImagemDataRepository
{
    public class ImagemRepository : BaseRepository<Imagem>, IBaseRepository<Imagem>
    {
        public ImagemRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
