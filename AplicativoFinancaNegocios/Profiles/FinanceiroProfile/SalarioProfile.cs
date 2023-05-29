using DTO.DTOs.Salario;
using DTO.Models.Financeiro;

namespace AplicativoFinancaNegocios.Profiles.FinanceiroProfile
{
    public class SalarioProfile : ProfileBase<CreateSalarioDTO,ReadSalarioDTO,UpdateSalarioDTO,DeleteSalarioDTO,FilterSalarioDTO,Financeiro>
    {
        public SalarioProfile()
        {
            Mapper();
        }
    }
}
