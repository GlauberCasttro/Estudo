using ApplicationApp.Interfaces;
using Domain.Interfaces.Models;
using Domain.Interfaces.Services;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduto : InterfaceProductApp
    {
        public readonly IProduct _product;
        public readonly IServiceProduto _serviceProduto;

        public AppProduto(IProduct product, IServiceProduto serviceProduto)
        {
            _product = product;
            _serviceProduto = serviceProduto;
        }

        public async Task Add(Produto entity)
        {
            await _product.Add(entity);
        }

        public async Task AddProduct(Produto product)
        {
            await _serviceProduto.AddProduct(product);
        }
        public async Task UpdateProduct(Produto product)
        {
            await _serviceProduto.UpdateProduct(product);
        }

        public async Task Delete(Produto entity)
        {
            await _product.Delete(entity);
        }

        public async Task<Produto> GetEntityById(int entity)
        {
            return await _product.GetEntityById(entity);
            
        }

        public async Task<List<Produto>> List()
        {
            return await _product.List();
        }

        public async  Task Update(Produto entity)
        {
            await _product.Update(entity);
        }

        
    }
}
