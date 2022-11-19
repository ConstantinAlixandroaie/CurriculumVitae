using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IEducationRepository:IRepository<Education>
    {

    }
    public class EducationRepository:Repository<Education>, IEducationRepository    
    {
        public EducationRepository(ApplicationDbContext ctx):base(ctx)
        {

        }

        public override Task<Education> Add(Education item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Education>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<Education> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Remove(Education item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Update(int id, Education newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
