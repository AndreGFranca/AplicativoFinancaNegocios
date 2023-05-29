using AplicativoFinancaNegocios.DataBase;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoFinancaNegocios.Applications
{
    public class ConsolidarBanco : IConsolidarBanco
    {
        readonly private ApplicationDBContext _context;
        public ConsolidarBanco(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task Salvar()
        {
            await _context.SaveChangesAsync();
        }
    }
}
