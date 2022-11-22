using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IRepository<T> where T : IDbObject
    {
        Task<IEnumerable<T>> Get(bool asNoTracking = false);
        Task<T> GetById(int id, bool asNoTracking = false);
        Task<T> Add(T item, ClaimsPrincipal user);
        Task<bool> Remove(T item, ClaimsPrincipal user);
        Task RemoveById(int id, ClaimsPrincipal user);
        Task<bool> Update(int id, T newData, ClaimsPrincipal user);
    }
}
