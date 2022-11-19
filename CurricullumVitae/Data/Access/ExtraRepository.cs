using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IExtraRepository :IRepository<Extra>
    {

    }
    public class ExtraRepository:Repository<Extra>,IExtraRepository
    {
        public ExtraRepository(ApplicationDbContext ctx):base(ctx)   
        {

        }

        public override Task<Extra> Add(Extra item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Extra>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<Extra> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Remove(Extra item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Update(int id, Extra newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
