using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IEducationRepository : IRepository<Education> 
    {
    }
    public class EducationRepository:Repository<Education>, IEducationRepository
    {
        public EducationRepository(MyCVDbContext ctx,ILogger<EducationRepository> logger):base(ctx, logger)
        {

        }

        public override Task<Education> Add(Education item)
        {
            throw new NotImplementedException();
        }

        public override Task<Education> Delete(Education item)
        {
            throw new NotImplementedException();
        }

        public override Task<Education> DeleteById(int id)
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

        public override Task<Education> Update(int id, Education newData)
        {
            throw new NotImplementedException();
        }
    }
}
