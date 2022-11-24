using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IWorkExperienceRepository:IRepository<WorkExperience>
    {

    }
    public class WorkExperienceRepository:Repository<WorkExperience>, IWorkExperienceRepository
    {
        public WorkExperienceRepository(MyCVDbContext ctx,ILogger<WorkExperienceRepository> logger):base(ctx,logger)
        {

        }

        public override Task<WorkExperience> Add(WorkExperience item)
        {
            throw new NotImplementedException();
        }

        public override Task<WorkExperience> Delete(WorkExperience item)
        {
            throw new NotImplementedException();
        }

        public override Task<WorkExperience> DeleteById(int id)
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

        public override Task<WorkExperience> Update(int id, WorkExperience newData)
        {
            throw new NotImplementedException();
        }
    }
}
