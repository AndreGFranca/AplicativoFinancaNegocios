using DTO.DTOs.Materiais.Cor;
using DTO.DTOs.Materiais.CorDTOs;
using DTO.DTOs.Materiais.MarcaDTOs;
using DTO.DTOs.Materiais.MaterialConfig;
using DTO.DTOs.Materiais.UnidadeDeMedidaDTOs;
using DTO.Utils;
using Microsoft.EntityFrameworkCore;

namespace AplicativoFinancaNegocios.Applications.MaterialViewApplication
{
    public class ConfigMaterialApplication : IBaseApplication
    {
        private CorApplication Cores { get; set; }
        private MarcaApplication Marcas { get; set; }
        private UnidadeDeMedidaApplication UnidadedDeMedida { get; set; }

        public ConfigMaterialApplication(CorApplication cores, MarcaApplication marcas, UnidadeDeMedidaApplication unidadedDeMedida)
        {
            Cores = cores;
            Marcas = marcas;
            UnidadedDeMedida = unidadedDeMedida;
        }
        public async Task AdicionarNovoRegistro<CreateDTO>(CreateDTO create)
        {
            try
            {
                if (create is CreateMaterialConfigDTO createDTO)
                {
                    if (createDTO.Cor != null)
                    {
                        await Cores.AdicionarNovoRegistro(createDTO.Cor);
                    }
                    if (createDTO.Marca != null)
                    {
                        await Marcas.AdicionarNovoRegistro(createDTO.Marca);
                    }
                    if (createDTO.UnidadeDeMedida != null)
                    {
                        await UnidadedDeMedida.AdicionarNovoRegistro(createDTO.UnidadeDeMedida);
                    }
                }
                else
                {
                    throw new Exception("Tipo de variavel errado");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public Task AtualizarRegistro<UpdateDto>(UpdateDto model, int id)
        {
            throw new NotImplementedException();
        }

        public Task DeletarRegistro<DeleteDto>(DeleteDto model, int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ReadMaterialConfigDTO> ObterConfigsMaterial()
        {
            ReadMaterialConfigDTO readMaterialConfigDTO = new ReadMaterialConfigDTO();
            readMaterialConfigDTO.Cores = await Cores.PesquisarRegistros<FilterCorDTO, ReadCorDTO>(x => x.Ativo == true).ToListAsync();
            readMaterialConfigDTO.UnidadesDeMedida = await UnidadedDeMedida.PesquisarRegistros<FilterUnidadeDeMedidaDTO, ReadUnidadeDeMedidaDTO>(x => x.Ativo == true).ToListAsync();
            readMaterialConfigDTO.Marcas = await Marcas.PesquisarRegistros<FilterMarcaDTO, ReadMarcaDTO>(x => x.Ativo == true).ToListAsync();
            //readMaterialConfigDTO.Cores = await Cores.ObterRegistrosDeLeitura<FilterCorDTO, ReadCorDTO>();
            //readMaterialConfigDTO.UnidadesDeMedida = await UnidadedDeMedida.ObterRegistrosDeLeitura<FilterUnidadeDeMedidaDTO, ReadUnidadeDeMedidaDTO>();
            //readMaterialConfigDTO.Marcas = await Marcas.ObterRegistrosDeLeitura<FilterMarcaDTO, ReadMarcaDTO>();

            return readMaterialConfigDTO;
        }

        public IQueryable<ReadDTO> PesquisarRegistros<FiltroDto, ReadDTO>(Func<FiltroDto, bool> filtroDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReadDTO>> ObterTodosOsRegistros<FiltroDto, ReadDTO>()
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<ReadDTO>> ObterRegistrosDeLeitura<FiltroDto, ReadDTO>()
        {
            throw new NotImplementedException();
        }

        public TipoB ConvesaoDeDTO<TipoA, TipoB>(TipoA dto)
        {
            throw new NotImplementedException();
        }
    }
}
