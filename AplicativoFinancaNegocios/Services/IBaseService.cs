using DTO.Models.ModelBase;
using DTO.Utils;

namespace AplicativoFinancaNegocios.Services
{
    public interface IBaseService<T> where T : ModeloBase
    {
        Task<T> AdicionarNovoRegistro<CreateDto>(CreateDto createDto);
        Task AtualizarRegistro<UpdateDto>(UpdateDto updateDto, int id);
        Task DeletarRegistro<DeleteDto>(DeleteDto deleteDto, int id);
        IQueryable<ReadDto> PesquisarRegistros<FiltroDto, ReadDto>(Func<FiltroDto, bool> filtroDto);
        TipoB ConvesaoDeDTO<TipoA, TipoB>(TipoA dto);
    }
}