using AplicativoFinancaNegocios.DataBase;
using AplicativoFinancaNegocios.Repository.EstoqueDataRepository;
using AplicativoFinancaNegocios.Repository.FinanceiroDataRepository;
using AplicativoFinancaNegocios.Repository.ImagemDataRepository;
using AplicativoFinancaNegocios.Repository.MaterialDataRepository;
using AplicativoFinancaNegocios.Repository.ProdutoDataRepository;
using DTO.Models.Estoque;
using DTO.Models.Financeiro;
using DTO.Models.Imagem;
using DTO.Models.Materiais;
using DTO.Models.Produtos;

namespace AplicativoFinancaNegocios.Config
{
    public static class RepositoryServiceRegistration
    {
        public static IServiceCollection AddRepositoriesServicesRegistration(this IServiceCollection services)
        {
            services.AddSingleton<IBaseRepository<Produto>, ProdutoRepository>();
            services.AddSingleton<IBaseRepository<Material>, MaterialRepository>();
            services.AddSingleton<IBaseRepository<UnidadeDeMedida>, UnidadeDeMedidaRepository>();
            services.AddSingleton<IBaseRepository<Marca>, MarcaRepository>();
            services.AddSingleton<IBaseRepository<Cor>, CorRepository>();
            services.AddSingleton<IBaseRepository<Imagem>, ImagemRepository>();
            services.AddSingleton<IBaseRepository<Financeiro>, FinanceiroRepository>();
            services.AddSingleton<IBaseRepository<HistoricoEstoque>, HistEstoqueRepository>();
            return services;
        }
    }
}
