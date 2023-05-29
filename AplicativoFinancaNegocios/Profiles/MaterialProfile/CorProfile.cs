using AutoMapper;
using DTO.DTOs.Materiais.Cor;
using DTO.DTOs.Materiais.CorDTOs;
using DTO.Models.Materiais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Profiles.MaterialProfile
{
    public class CorProfile : ProfileBase<CreateCorDTO, ReadCorDTO, UpdateCorDTO, DeleteCorDTO, FilterCorDTO, Cor>
    {
        public CorProfile()
        {
            Mapper();
        }
    }
}
