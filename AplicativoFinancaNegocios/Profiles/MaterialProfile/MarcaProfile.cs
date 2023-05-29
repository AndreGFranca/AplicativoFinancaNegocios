using DTO.DTOs.Materiais.MarcaDTOs;
using DTO.Models.Materiais;

namespace AplicativoFinancaNegocios.Profiles.MaterialProfile
{
    public class MarcaProfile : ProfileBase<CreateMarcaDTO, ReadMarcaDTO, UpdateMarcaDTO, DeleteMarcaDTO, FilterMarcaDTO, Marca>
    {
        public MarcaProfile()
        {
            Mapper();
        }
    }
}
