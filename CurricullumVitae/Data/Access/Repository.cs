using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public class Repository<T> : IRepository<T> where T:class, IDbObject
    {
        public Task<T> Add(T item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

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
