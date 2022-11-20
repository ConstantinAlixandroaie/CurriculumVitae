using CurricullumVitae.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IProfilePictureRepository : IRepository<ProfilePicture>
    {

    }
    public class ProfilePictureRepository : Repository<ProfilePicture>, IProfilePictureRepository
    {
        public ProfilePictureRepository(ApplicationDbContext ctx, ILogger<ProfilePictureRepository> logger) : base(ctx, logger)
        {

        }

        public override async Task<ProfilePicture> Add(ProfilePicture item, ClaimsPrincipal user)
        {
            if (item == null)
            {
                return null;
            }

            try
            {
                var profilePicture = new ProfilePicture
                {
                    Id = item.Id,
                    Document = item.Document,
                    DocumentId = item.DocumentId,
                    ImageUrl = item.ImageUrl,
                };

                _ctx.ProfilePictures.Add(profilePicture);
                await _ctx.SaveChangesAsync();
                return profilePicture;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "An error occurred adding the profile picture in the database.");
                throw;
            }
        }

        public override async Task<IEnumerable<ProfilePicture>> Get(bool asNoTracking = false)
        {
            try
            {
                var rv = new List<ProfilePicture>();
                var sourceCollection = await _ctx.ProfilePictures.ToListAsync();
                foreach (var source in sourceCollection)
                {
                    var vm = new ProfilePicture()
                    {
                        Id = source.Id,
                        Document = source.Document,
                        DocumentId = source.DocumentId,
                        ImageUrl = source.ImageUrl,
                    };
                    rv.Add(vm);
                }
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<ProfilePicture> GetById(int id, bool asNoTracking = false)
        {
            try
            {
                var sourceCollection = _ctx.ProfilePictures.AsQueryable();
                if (asNoTracking)
                {
                    sourceCollection = sourceCollection.AsNoTracking();
                }
                var profilePicture = await sourceCollection.FirstOrDefaultAsync(x => x.Id == id);
                if (profilePicture == null)
                {
                    return null;
                }
                var rv = new ProfilePicture()
                {
                    Id = profilePicture.Id,
                    Document = profilePicture.Document,
                    DocumentId = profilePicture.DocumentId,
                    ImageUrl = profilePicture.ImageUrl,

                };
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override Task<bool> Remove(ProfilePicture item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override async Task RemoveById(int id, ClaimsPrincipal user)
        {
            try
            {
                var profilePicture = await _ctx.ProfilePictures.FirstOrDefaultAsync(x => x.Id == id);
                if (profilePicture == null)
                    throw new ArgumentNullException(nameof(profilePicture), $"The Profile Picture with Id= '{id}' does not exist.");

                //authorization
                _ctx.ProfilePictures.Remove(profilePicture);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);   
                throw;
            }
        }

        public override async Task<bool> Update(int id, ProfilePicture newData, ClaimsPrincipal user)
        {
            try
            {
                var profilePicture = await _ctx.ProfilePictures.FirstOrDefaultAsync(x => x.Id == id);
                if (profilePicture==null)
                {
                    return false;
                }
                if (!string.IsNullOrEmpty(newData.ImageUrl))
                {
                    profilePicture.ImageUrl = newData.ImageUrl;
                }
                await _ctx.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
