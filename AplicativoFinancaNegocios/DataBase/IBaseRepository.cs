using DTO.Models.ModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.DataBase
{
    public interface IBaseRepository<TModel> where TModel : Auditoria
    {
        Task<TModel> Adicionar(TModel model);
        Task Atualizar(TModel model);
        Task Deletar(TModel model);
        IQueryable<TModel> Pesquisar();
    }
}
