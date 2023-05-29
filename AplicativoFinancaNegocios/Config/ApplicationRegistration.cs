using AplicativoFinancaNegocios.Applications;
using AplicativoFinancaNegocios.Applications.EstoqueViewApplication;
using AplicativoFinancaNegocios.Applications.FinanceiroViewApplication;
using AplicativoFinancaNegocios.Applications.ImagemViewApplication;
using AplicativoFinancaNegocios.Applications.MaterialViewApplication;
using AplicativoFinancaNegocios.Applications.ProdutoViewApplication;

namespace AplicativoFinancaNegocios.Config
{
    public static class ApplicationRegistration
    {        
        public static IServiceCollection AddAplicationRegistration(this IServiceCollection services)
        {
            // Lógica personalizada para registrar seus serviços
            services.AddSingleton<IConsolidarBanco, ConsolidarBanco>();
            services.AddSingleton<ProdutoApplication>();
            services.AddSingleton<MaterialApplication>();
            services.AddSingleton<ConfigMaterialApplication>();
            services.AddSingleton<UnidadeDeMedidaApplication>();
            services.AddSingleton<MarcaApplication>();
            services.AddSingleton<CorApplication>();
            services.AddSingleton<ImagemApplication>();
            services.AddSingleton<SalarioApplication>();
            services.AddSingleton<DespesaApplication>();
            services.AddSingleton<HistEstoqueApplication>();

            return services;
        }
        
    }
}
