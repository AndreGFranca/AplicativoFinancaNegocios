using AutoMapper;
using DTO.DTOs.Imagem;
using DTO.DTOs.Materiais;
using DTO.Models.Imagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Profiles.ImagemProfile
{
    public class ImagemProfile:ProfileBase<CreateImagemDTO,ReadImagemDTO,UpdateImagemDTO,DeleteImagemDTO,FilterImagemDTO,Imagem>
    {
        public ImagemProfile()
        {
            Mapper();
        }
    }
}
