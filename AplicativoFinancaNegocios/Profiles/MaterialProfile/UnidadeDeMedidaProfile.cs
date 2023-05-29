using DTO.DTOs.Materiais.UnidadeDeMedidaDTOs;
using DTO.Models.Materiais;

namespace AplicativoFinancaNegocios.Profiles.MaterialProfile
{
    public class UnidadeDeMedidaProfile:ProfileBase<CreateUnidadeDeMedidaDTO,ReadUnidadeDeMedidaDTO,UpdateUnidadeDeMedidaDTO,DeleteUnidadeDeMedidaDTO,FilterUnidadeDeMedidaDTO,UnidadeDeMedida>
    {
        public UnidadeDeMedidaProfile()
        {
            Mapper();
        }
    }
}
