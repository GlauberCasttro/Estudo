using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services
{
    public interface IServiceProduto
    {
        Task AddProduct(Produto product);
        Task UpdateProduct(Produto product);
    }
}
