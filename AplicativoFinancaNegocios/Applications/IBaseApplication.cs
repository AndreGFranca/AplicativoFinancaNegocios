using DTO.DTOs.Materiais.MaterialConfig;
using DTO.Utils;

namespace AplicativoFinancaNegocios.Applications
{
    public interface IBaseApplication
    {
        Task AdicionarNovoRegistro<CreateDTO>(CreateDTO model);
        Task AtualizarRegistro<UpdateDto>(UpdateDto model, int id);
        Task DeletarRegistro<DeleteDto>(DeleteDto model, int id);
        IQueryable<ReadDTO> PesquisarRegistros<FiltroDto, ReadDTO>(Func<FiltroDto, bool> filtroDto);
        Task<IEnumerable<ReadDTO>> ObterTodosOsRegistros<FiltroDto, ReadDTO>();
        Task<IReadOnlyList<ReadDTO>> ObterRegistrosDeLeitura<FiltroDto, ReadDTO>();
        TipoB ConvesaoDeDTO<TipoA, TipoB>(TipoA dto);
    }
}