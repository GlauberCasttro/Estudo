using DEMO_DDD.APPLICATION.Interfaces;
using DEMO_DDD.DOMAIN.Entidades;
using DEMO_DDD.DOMAIN.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_DDD.APPLICATION.Services
{
    public class AppClienteService : AppServiceBase<Cliente>, IClienteAppService
    {
        //Camada de dominio
        private readonly IClienteService _clienteService;
        public AppClienteService(IClienteService clienteService) : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<IEnumerable<Cliente>> ObterClientesEspeciaisAsync()
        {
            return _clienteService.ObterClientesEspeciais(await _clienteService.ObterTodos());
        }



        public async Task<IEnumerable<Cliente>> ObterClientesProdutos()
        {
            return await _clienteService.ObterClientesProdutos();
        }
    }
}
