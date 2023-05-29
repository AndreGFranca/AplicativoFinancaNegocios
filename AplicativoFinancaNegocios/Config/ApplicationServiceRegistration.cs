using AplicativoFinancaNegocios.Services;
using AplicativoFinancaNegocios.Services.EstoqueServices;
using AplicativoFinancaNegocios.Services.FinanceiroServices;
using AplicativoFinancaNegocios.Services.ImagemServices;
using AplicativoFinancaNegocios.Services.MaterialServices;
using AplicativoFinancaNegocios.Services.ProdutoService;
using AplicativoFinancaNegocios.Services.SalarioServices;
using DTO.Models.Estoque;
using DTO.Models.Financeiro;
using DTO.Models.Imagem;
using DTO.Models.Materiais;
using DTO.Models.Produtos;

namespace AplicativoFinancaNegocios.Config
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddAplicationServicesRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IBaseService<Produto>, ProdutoService>();
            services.AddSingleton<IBaseService<Material>, MaterialService>();
            services.AddSingleton<IBaseService<UnidadeDeMedida>, UnidadeDeMedidaService>();
            services.AddSingleton<IBaseService<Marca>, MarcaService>();
            services.AddSingleton<IBaseService<Cor>, CorService>();
            services.AddSingleton<IBaseService<Imagem>, ImagemService>();
            services.AddSingleton<IBaseService<Financeiro>, SalarioService>();
            services.AddSingleton<IBaseService<Financeiro>, DespesaService>();
            services.AddSingleton<IBaseService<HistoricoEstoque>, HistEstoqueService>();

            return services;
        }
    }
}
