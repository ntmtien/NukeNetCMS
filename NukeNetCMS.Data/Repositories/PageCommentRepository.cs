﻿using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IPageCommentRepository : IRepository<PageComment>
    {
    }

    public class PageCommentRepository : RepositoryBase<PageComment>, IPageCommentRepository
    {
        public PageCommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}