using CurricullumVitae.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IEducationRepository : IRepository<Education>
    {

    }
    public class EducationRepository : Repository<Education>, IEducationRepository
    {
        public EducationRepository(ApplicationDbContext ctx, ILogger<EducationRepository> logger) : base(ctx, logger)
        {

        }

        public override async Task<Education> Add(Education item, ClaimsPrincipal user)
        {
            if (item == null)
                return null;
            if (string.IsNullOrEmpty(item.Title))
                return null;
            try
            {
                var education = new Education
                {
                    Title = item.Title,
                    Description = item.Description,
                    Document = item.Document,
                    DocumentId = item.DocumentId,
                    EndDate = item.EndDate,
                    StartDate = item.StartDate,
                    University = item.University,
                };
                _ctx.Educations.Add(education);
                await _ctx.SaveChangesAsync();
                return education;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<IEnumerable<Education>> Get(bool asNoTracking = false)
        {
            try
            {
                var rv = new List<Education>();
                var sourceCollection = await _ctx.Educations.ToListAsync();
                foreach (var source in sourceCollection)
                {
                    var vm = new Education()
                    {
                        Title = source.Title,
                        Description = source.Description,
                        Document = source.Document,
                        DocumentId = source.DocumentId,
                        EndDate = source.EndDate,
                        StartDate = source.StartDate,

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

        public override async Task<Education> GetById(int id, bool asNoTracking = false)
        {
            try
            {
                var sourceCollection = _ctx.Educations.AsQueryable();
                if (asNoTracking)
                {
                    sourceCollection = sourceCollection.AsNoTracking();
                }
                var education = await sourceCollection.FirstOrDefaultAsync(x => x.Id == id);
                if (education == null)
                {
                    return null;
                }
                var rv = new Education()
                {
                    Title = education.Title,
                    Description = education.Description,
                    Document = education.Document,
                    DocumentId = education.DocumentId,
                    EndDate = education.EndDate,
                    StartDate = education.StartDate,

                };
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override Task<bool> Remove(Education item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override async Task RemoveById(int id, ClaimsPrincipal user)
        {
            try
            {
                var education = await _ctx.Educations.FirstOrDefaultAsync(x => x.Id == id);
                if (education == null)
                {
                    throw new ArgumentNullException(nameof(education));
                }
                //authorization
                _ctx.Educations.Remove(education);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }

        }

        public override async Task<bool> Update(int id, Education newData, ClaimsPrincipal user)
        {
            try
            {
                var education = await _ctx.Educations.FirstOrDefaultAsync(x=>x.Id == id);
                if(education == null) 
                {
                    return false;
                }
                if (newData.StartDate!=education.StartDate)
                {
                    education.StartDate = newData.StartDate;
                }
                if (newData.EndDate!= education.EndDate)
                {
                    education.EndDate = newData.EndDate;
                }
                if (!string.IsNullOrEmpty(newData.Description))
                {
                    education.Description = newData.Description;
                }
                if (!string.IsNullOrEmpty(newData.Title))
                {
                    education.Title = newData.Title;
                }
                if (!string.IsNullOrEmpty(newData.University))
                {
                    education.University = newData.University;
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
