using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public abstract class Repository<T> : IRepository<T> where T : class, IDbObject
    {
        protected ApplicationDbContext _ctx;
        protected readonly ILogger _logger;
        public Repository(ApplicationDbContext ctx, ILogger<Repository<T>> logger)
        {
            _ctx = ctx;
            _logger= logger;
        }
        public abstract Task<T> Add(T item, ClaimsPrincipal user);
        public abstract Task<IEnumerable<T>> Get(bool asNoTracking = false);
        public abstract Task<T> GetById(int id, bool asNoTracking = false);
        public abstract Task<bool> Remove(T item, ClaimsPrincipal user);
        public abstract Task RemoveById(int id, ClaimsPrincipal user);
        public abstract Task<bool> Update(int id, T newData, ClaimsPrincipal user);

        public Task<bool> Remove(T item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, T newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
