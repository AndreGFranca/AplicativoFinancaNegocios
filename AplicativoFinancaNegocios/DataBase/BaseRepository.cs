using AutoMapper;
using DTO.Models.ModelBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.DataBase
{
    public abstract class BaseRepository<T>:
        IDisposable,
        IBaseRepository<T> where T : Auditoria
        
    {
        protected readonly ApplicationDBContext _context;
        public BaseRepository(ApplicationDBContext context)
        {
            _context = context;           
        }
        public async virtual Task<T> Adicionar(T model)
        {
            await _context.Set<T>().AddAsync(model);
            return model;
        }

        public async virtual Task Atualizar(T model)
        {
            _context.Set<T>().Update(model);
        }

        public async virtual Task Deletar(T model)
        {            
            model.Ativo = false;
            _context.Set<T>().Update(model);
        }

        public virtual IQueryable<T> Pesquisar()
        {
            return _context.Set<T>().AsQueryable();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
