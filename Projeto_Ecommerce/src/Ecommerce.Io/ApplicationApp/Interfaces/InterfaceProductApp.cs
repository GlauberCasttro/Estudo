﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceProductApp : IGenericsApp<Produto>
    {
        Task AddProduct(Produto product);
        Task UpdateProduct(Produto product);
    }
}