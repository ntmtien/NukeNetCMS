﻿using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IProductCommentRepository : IRepository<ProductComment>
    {
    }

    public class ProductCommentRepository : RepositoryBase<ProductComment>, IProductCommentRepository
    {
        public ProductCommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}