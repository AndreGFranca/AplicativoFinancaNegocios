using DTO.DTOs.Estoque;
using DTO.Models.Estoque;

namespace AplicativoFinancaNegocios.Profiles.EstoqueProfile
{
    public class HistEstoqueProfile : ProfileBase<CreateHistoricoEstoqueDTO, ReadHistoricoEstoqueDTO, UpdateHistoricoEstoqueDTO, DeleteHistoricoEstoqueDTO, FilterHistoricoEstoqueDTO, HistoricoEstoque>
    {
        public HistEstoqueProfile()
        {
            Mapper();
        }
    }
}
