using AutoMapper;
using DTO.DTOs.Produtos.ComposicaoProduto;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Profiles.ProdutoProfile
{
    public class ProdutoComposicaoProfile:Profile
    {
        public ProdutoComposicaoProfile()
        {
            CreateMap<CreateProdutoComposicaoDTO, ProdutoComposicao>();
            CreateMap<ProdutoComposicao, ReadProdutoComposicaoDTO>();
            CreateMap<CreateProdutoComposicaoDTO, ProdutoComposicao>();
            CreateMap<CreateProdutoComposicaoDTO, ReadProdutoComposicaoDTO>();
        }
    }
}
