using AplicativoFinancaNegocios.DataBase;
using AutoMapper;
using DTO.Models.ModelBase;
using DTO.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : ModeloBase
    {
        protected IMapper _mapper;
        protected readonly IBaseRepository<T> _context;
        public BaseService(IMapper mapper, IBaseRepository<T> context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async virtual Task<T> AdicionarNovoRegistro<CreateDto>(CreateDto createDto)
        {
            T model = _mapper.Map<T>(createDto);
            return await _context.Adicionar(model);
        }
        public async virtual Task AtualizarRegistro<UpdateDto>(UpdateDto updateDto, int id)
        {
            var model = await PesquisarRegistros<T, T>(x => x.Id == id)
                .FirstOrDefaultAsync();

            if (model != null)
            {
                _mapper.Map(updateDto, model);
                await _context.Atualizar(model);
            }
            else
            {
                throw new Exception("Registro não encontrado");
            }
        }
        public async virtual Task DeletarRegistro<DeleteDto>(DeleteDto deleteDto, int id)
        {
            T model = _mapper.Map<T>(deleteDto);
            await _context.Deletar(model);
        }
        public virtual IQueryable<ReadDto> PesquisarRegistros<FiltroDto, ReadDto>(Func<FiltroDto, bool> filtroDto) {
            IQueryable<T> query = _context.Pesquisar();
            if (filtroDto != null)
            {
                Expression<Func<T, bool>> filtro = ConvertToExpression(filtroDto);
                query.Where(filtro);                
            }
            return query.Select(entity => _mapper.Map<ReadDto>(entity));
        }
        private Expression<Func<T, bool>> ConvertToExpression<FiltroDto>(Func<FiltroDto, bool> filtroDto)
        {
            ParameterExpression parameter = Expression.Parameter(typeof(T), "entity");
            FiltroDto dto = Activator.CreateInstance<FiltroDto>();

            var body = Expression.Invoke(Expression.Constant(filtroDto), Expression.Constant(dto));
            var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);

            return lambda;
        }
        public virtual TipoB ConvesaoDeDTO<TipoA, TipoB>(TipoA dto)
        {
            return _mapper.Map<TipoB>(dto);
        }
    }
}
