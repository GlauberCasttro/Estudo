using DEMO_DDD.DOMAIN.Entidades;
using DEMO_DDD.DOMAIN.Interfaces.Repositories;
using DEMO_DDD.INFRA.DATA.Contexto;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO_DDD.INFRA.DATA.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {

        public ClienteRepository(DemoDDDContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Cliente>> ObterClientesProdutos()
        {
            return await _context.Clientes.AsNoTracking().Include(c => c.Produtos).ToListAsync();
            
           
        }

        public async Task<Produto> ObterProdutosPorCliente(int id)
        {
            return await _context.Produtos.AsNoTracking().Include(c => c.Cliente).FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
