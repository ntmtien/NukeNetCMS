﻿using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface ICouponRepository
    {
    }

    public class CouponRepository : RepositoryBase<Coupon>, ICouponRepository
    {
        public CouponRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}