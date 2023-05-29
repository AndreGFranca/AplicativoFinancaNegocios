using AplicativoFinancaNegocios.Services;
using DTO.DTOs.Materiais.MaterialConfig;
using DTO.Models.ModelBase;
using DTO.Utils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications
{
    public abstract class BaseApplication<T> : IBaseApplication where T : ModeloBase
    {
        public readonly IConsolidarBanco _context;
        public readonly IBaseService<T> _baseService;

        public BaseApplication(IConsolidarBanco context, IBaseService<T> baseService)
        {
            _context = context;
            _baseService = baseService;
        }

        public async virtual Task AdicionarNovoRegistro<CreateDTO>(CreateDTO model)
        {
            try
            {
                await _baseService.AdicionarNovoRegistro(model);
                await _context.Salvar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível completar o registro devido ao erro: {ex.Message}");
            }
        }
        public async virtual Task AtualizarRegistro<UpdateDto>(UpdateDto model, int id)
        {
            try
            {
                await _baseService.AtualizarRegistro(model, id);
                await _context.Salvar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível atualizar o registro devido ao erro: {ex.Message}");
            }
        }
        public async virtual Task DeletarRegistro<DeleteDto>(DeleteDto model, int id)
        {
            try
            {
                await _baseService.DeletarRegistro(model, id);
                await _context.Salvar();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível deletar o registro devido ao erro: {ex.Message}");
            }
        }

        public async Task<IReadOnlyList<ReadDTO>> ObterRegistrosDeLeitura<FiltroDto, ReadDTO>()
        {
            try
            {
                return await PesquisarRegistros<FiltroDto, ReadDTO>(null).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível Encontrar os registros devido ao erro: {ex.Message}");
            }
        }

        public async Task<IEnumerable<ReadDTO>> ObterTodosOsRegistros<FiltroDto, ReadDTO>()
        {
            try
            {
                return await PesquisarRegistros<FiltroDto, ReadDTO>(null).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível Encontrar os registros devido ao erro: {ex.Message}");
            }
            
        }

        public virtual IQueryable<ReadDTO> PesquisarRegistros<FiltroDto,ReadDTO>(Func<FiltroDto, bool> filtroDto)
        {
            try
            {
                return _baseService.PesquisarRegistros<FiltroDto, ReadDTO>(filtroDto);
            }
            catch (Exception ex)
            {
                throw new Exception($"Não foi possível Encontrar os registros devido ao erro: {ex.Message}");
            }
        }
        public virtual TipoB ConvesaoDeDTO<TipoA, TipoB>(TipoA dto)
        {
            return _baseService.ConvesaoDeDTO<TipoA, TipoB>(dto);
        }

    }
}
