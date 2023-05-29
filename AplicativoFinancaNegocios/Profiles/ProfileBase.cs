using AutoMapper;
using DTO.DTOs.Produtos;
using DTO.Models.ModelBase;
using DTO.Models.Produtos;
using DTO.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Profiles
{
    public class ProfileBase<CreateDTO,ReadDTO,UpdateDTO,DeleteDTO,FilterDTO,Model> : Profile where Model : ModeloBase where FilterDTO : BaseFiltroDTO
    {        
        public void Mapper()
        {
            CreateMap<CreateDTO, Model>();
            CreateMap<Model, ReadDTO>();
            CreateMap<UpdateDTO, Model>();
            CreateMap<CreateDTO, ReadDTO>();
            CreateMap<DeleteDTO, Model>();
            CreateMap<FilterDTO, Model>();
            CreateMap<Model, FilterDTO>();
            CreateMap<ReadDTO, UpdateDTO>();
        }
    }
}
