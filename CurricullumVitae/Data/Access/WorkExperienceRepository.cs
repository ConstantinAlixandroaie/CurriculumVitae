using CurricullumVitae.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IWorkExperienceRepository:IRepository<WorkExperience>
    {

    }
    public class WorkExperienceRepository:Repository<WorkExperience>,IWorkExperienceRepository
    {
        public WorkExperienceRepository(ApplicationDbContext ctx,ILogger<WorkExperienceRepository> logger) : base(ctx,logger)
        {

        }

        public override async Task<WorkExperience> Add(WorkExperience item, ClaimsPrincipal user)
        {
            if (item==null)
            {
                return null;
            }
            if (item.Title==null)
            {
                return null;
            }
            try
            {
                var workExperience = new WorkExperience
                {
                    Title = item.Title,
                    Description = item.Description,
                    DocumentId = item.DocumentId,
                    Document = await _ctx.Documents.FirstOrDefaultAsync(x => x.Id == item.DocumentId),
                    EndDate = item.EndDate,
                    StartDate = item.StartDate,
                };

                _ctx.WorkExperiences.Add(workExperience);
                await _ctx.SaveChangesAsync();
                return workExperience;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, "An error occurred adding the work experience in the database.");
                throw;
            }

        }

        public override async Task<IEnumerable<WorkExperience>> Get(bool asNoTracking = false)
        {
            try
            {
                var rv = new List<WorkExperience>();
                var sourceCollection = await _ctx.WorkExperiences.ToListAsync();
                foreach (var source in sourceCollection) 
                {
                    var vm = new WorkExperience()
                    {
                        Title = source.Title,
                        Description = source.Description,
                        DocumentId = source.DocumentId,
                        StartDate= source.StartDate,
                        EndDate= source.EndDate,
                        Document=source.Document,
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

        public override async Task<WorkExperience> GetById(int id, bool asNoTracking = false)
        {
            try
            {
                var sourceCollection=_ctx.WorkExperiences.AsQueryable();
                if(asNoTracking)
                {
                    sourceCollection = sourceCollection.AsNoTracking();
                }
                var workExperience= await sourceCollection.FirstOrDefaultAsync(x=> x.Id==id);
                if (workExperience==null)
                {
                    return null;
                }
                var rv = new WorkExperience()
                { 
                    Id=workExperience.Id,
                    Title=workExperience.Title,
                    Description=workExperience.Description,
                    DocumentId=workExperience.DocumentId,
                    StartDate=workExperience.StartDate,
                    EndDate=workExperience.EndDate,
                    Document=workExperience.Document,
                };
                return rv;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override Task<bool> Remove(WorkExperience item, ClaimsPrincipal user)
        {
            //not likely to be necessary
            throw new NotImplementedException();
        }

        public override async Task RemoveById(int id, ClaimsPrincipal user)
        {
            try
            {
                var workExperience = await _ctx.WorkExperiences.FirstOrDefaultAsync(x => x.Id == id);
                if (workExperience==null) 
                {
                    throw new ArgumentNullException(nameof(workExperience));
                }
                //authorization 
                _ctx.WorkExperiences.Remove(workExperience); 
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<bool> Update(int id, WorkExperience newData, ClaimsPrincipal user)
        {
            try
            {
                var workExperience = await _ctx.WorkExperiences.FirstOrDefaultAsync(x=>x.Id== id);
                if (workExperience == null)
                    return false;
                //atuhorization
                if (!string.IsNullOrEmpty(newData.Description))
                {
                    workExperience.Description = newData.Description;
                }
                if (!string.IsNullOrEmpty(newData.Title))
                {
                    workExperience.Title = newData.Title;
                }
                if (newData.StartDate!=workExperience.StartDate)
                {
                    workExperience.StartDate = newData.StartDate;
                }
                if (newData.EndDate != workExperience.EndDate)
                {
                    workExperience.StartDate = newData.StartDate;
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
