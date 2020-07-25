using Domain.Interfaces.Models;
using Domain.Interfaces.Services;
using Entities.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceProduto : IServiceProduto
    {
        private readonly IProduct _product;
        public ServiceProduto(IProduct product)
        {
            _product = product;
        }
        public async Task AddProduct(Produto product)
        {
            var validaNome = product.ValidaPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if(validaNome && validaValor)
            {
                product.Estado = true;
                await _product.Add(product);
            }
        }

        public async Task UpdateProduct(Produto product)
        {
            var validaNome = product.ValidaPropriedadeString(product.Nome, "Nome");
            var validaValor = product.ValidarPropriedadeDecimal(product.Valor, "Valor");

            if (validaNome && validaValor)
            { 
                await _product.Update(product);
            }
        }
    }
}
