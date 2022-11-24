using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IExtraRepository:IRepository<Extra>
    {

    }
    public class ExtraRepository:Repository<Extra>,IExtraRepository
    {
        public ExtraRepository(MyCVDbContext ctx,ILogger<ExtraRepository> logger):base(ctx,logger)
        {

        }

        public override Task<Extra> Add(Extra item)
        {
            throw new NotImplementedException();
        }

        public override Task<Extra> Delete(Extra item)
        {
            throw new NotImplementedException();
        }

        public override Task<Extra> DeleteById(int id)
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

        public override Task<Extra> Update(int id, Extra newData)
        {
            throw new NotImplementedException();
        }
    }
}
