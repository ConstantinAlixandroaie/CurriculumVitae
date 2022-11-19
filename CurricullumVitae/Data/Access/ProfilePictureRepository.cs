using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IProfilePictureRepository:IRepository<ProfilePicture>
    {

    }
    public class ProfilePictureRepository : Repository<ProfilePicture>,IProfilePictureRepository
    {
        public ProfilePictureRepository(ApplicationDbContext ctx):base(ctx)
        {

        }

        public override Task<ProfilePicture> Add(ProfilePicture item, ClaimsPrincipal user)
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

        public override Task<bool> Remove(ProfilePicture item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Update(int id, ProfilePicture newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
