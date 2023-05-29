using DTO.DTOs.Materiais.MaterialDTOs;
using DTO.Models.Materiais;

namespace AplicativoFinancaNegocios.Profiles.MaterialProfile
{
    public class MaterialProfile : ProfileBase<CreateMaterialDTO,ReadMaterialDTO,UpdateMaterialDTO,DeleteMaterialDTO,FilterMaterialDTO,Material>
    {
        public MaterialProfile()
        {
            Mapper();
        }
    }
}
