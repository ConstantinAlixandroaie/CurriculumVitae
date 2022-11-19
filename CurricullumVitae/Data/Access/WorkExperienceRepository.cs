using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IWorkExperienceRepository:IRepository<WorkExperience>
    {

    }
    public class WorkExperienceRepository:Repository<WorkExperience>,IWorkExperienceRepository
    {
        public WorkExperienceRepository(ApplicationDbContext ctx) : base(ctx)
        {

        }

        public override Task<WorkExperience> Add(WorkExperience item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<WorkExperience>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<WorkExperience> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Remove(WorkExperience item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Update(int id, WorkExperience newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
