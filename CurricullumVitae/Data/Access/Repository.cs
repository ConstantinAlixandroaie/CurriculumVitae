﻿using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public abstract class Repository<T> : IRepository<T> where T : class, IDbObject
    {
        protected ApplicationDbContext _ctx;
        public Repository(ApplicationDbContext ctx)
        {
            _ctx = ctx;

        }
        public abstract Task<T> Add(T item, ClaimsPrincipal user);
        public abstract Task<IEnumerable<T>> Get(bool asNoTracking = false);
        public abstract Task<T> GetById(int id, bool asNoTracking = false);
        public abstract Task<bool> Remove(T item, ClaimsPrincipal user);
        public abstract Task RemoveById(int id, ClaimsPrincipal user);
        public abstract Task<bool> Update(int id, T newData, ClaimsPrincipal user);


    }
}
