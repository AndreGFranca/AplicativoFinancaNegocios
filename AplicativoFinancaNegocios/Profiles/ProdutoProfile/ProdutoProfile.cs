using AutoMapper;
using DTO.DTOs.Materiais;
using DTO.DTOs.Produtos.ProdutoDTOs;
using DTO.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Profiles.ProdutoProfile
{
    public class ProdutoProfile : ProfileBase<CreateProdutoDTO,ReadProdutoDTO,UpdateProdutoDTO,DeleteProdutoDTO,FilterProdutoDTO,Produto>
    {
        public ProdutoProfile()
        {
            Mapper();
        }
    }
}
