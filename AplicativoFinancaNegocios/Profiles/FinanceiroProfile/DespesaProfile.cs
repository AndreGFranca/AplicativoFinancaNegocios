using DTO.DTOs.Despesa;
using DTO.Models.Financeiro;

namespace AplicativoFinancaNegocios.Profiles.FinanceiroProfile
{
    public class DespesaProfile:ProfileBase<CreateDespesaDTO,ReadDespesaDTO,UpdateDespesaDTO,DeleteDespesaDTO,FilterDespesaDTO,Financeiro>
    {
        public DespesaProfile()
        {
            Mapper();
        }
    }
}
