﻿using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}