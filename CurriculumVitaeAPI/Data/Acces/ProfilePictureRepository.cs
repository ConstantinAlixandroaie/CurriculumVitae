using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IProfilePicturerepository : IRepository<ProfilePicture>
    {

    }
    public class ProfilePictureRepository : Repository<ProfilePicture>, IProfilePicturerepository
    {
        public ProfilePictureRepository(MyCVDbContext ctx, ILogger<ProfilePictureRepository> logger) : base(ctx, logger)
        {

        }

        public override Task<ProfilePicture> Add(ProfilePicture item)
        {
            throw new NotImplementedException();
        }

        public override Task<ProfilePicture> Delete(ProfilePicture item)
        {
            throw new NotImplementedException();
        }

        public override Task<ProfilePicture> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<ProfilePicture>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<ProfilePicture> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<ProfilePicture> Update(int id, ProfilePicture newData)
        {
            throw new NotImplementedException();
        }
    }
}
