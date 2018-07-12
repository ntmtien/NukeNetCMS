﻿using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface ILanguageRepository
    {
    }

    public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository
    {
        public LanguageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}