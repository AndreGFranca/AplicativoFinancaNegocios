using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.DTOs.Imagem;
using DTO.DTOs.Produtos;
using DTO.Models.Produtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services.ProdutoService
{
    public class ProdutoService: BaseService<Produto>,IBaseService<Produto>
    {
        public ProdutoService(IMapper mapper, IBaseRepository<Produto> context) : base(mapper, context)
        {
        }
    }
}
