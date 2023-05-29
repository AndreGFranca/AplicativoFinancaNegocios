using AplicativoFinancaNegocios.Services;
using DTO.DTOs.Imagem;
using DTO.Models.Imagem;

namespace AplicativoFinancaNegocios.Applications.ImagemViewApplication
{
    public class ImagemApplication : BaseApplication<Imagem>, IBaseApplication
    {
        public ImagemApplication(IConsolidarBanco context, IBaseService<Imagem> baseService) : base(context, baseService)
        {
        }
    }
}
