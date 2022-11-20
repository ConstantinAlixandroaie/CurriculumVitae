using CurricullumVitae.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.SymbolStore;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    //to add crud code to all repositories.
    public interface IDocumentRepository : IRepository<Document>
    {

    }
   
    public class DocumentRepository:Repository<Document>,IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext ctx,ILogger<DocumentRepository> logger):base(ctx,logger)
        {

        }

        public override async Task<Document> Add(Document item, ClaimsPrincipal user)
        {
            if (item==null)
            {
                return null;
            }
            try
            {
                var document = new Document
                {
                    Id = item.Id,
                    Description = item.Description,
                    Education = item.Education,
                    Extra = item.Extra,
                    WorkExperience = item.WorkExperience,
                    ProfilePicture = item.ProfilePicture,
                };

                _ctx.Documents.Add(document);
                await _ctx.SaveChangesAsync();
                return document;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<IEnumerable<Document>> Get(bool asNoTracking = false)
        {
            try
            {
                var rv = new List<Document>();
                var sourceCollection = await _ctx.Documents.ToListAsync();
                foreach (var source in sourceCollection)
                {
                    var vm = new Document()
                    {
                        Id = source.Id,
                        Description = source.Description,
                        Education = source.Education,
                        Extra = source.Extra,
                        WorkExperience = source.WorkExperience,
                        ProfilePicture = source.ProfilePicture,
                    };
                    rv.Add(vm);
                }
                return rv;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message); 
                throw;
            }

        }

        public override async Task<Document> GetById(int id, bool asNoTracking = false)
        {
            try
            {
                var sourceCollection =  _ctx.Documents.AsQueryable();
                if (asNoTracking)
                {
                    sourceCollection = sourceCollection.AsNoTracking();
                }
                var document= await sourceCollection.FirstOrDefaultAsync(x=>x.Id==id);
                if (document==null)
                {
                    return null;
                }
                var rv = new Document()
                {
                    Id = document.Id,
                    Description = document.Description,
                    Education = document.Education,
                    Extra = document.Extra,
                    WorkExperience = document.WorkExperience,
                    ProfilePicture = document.ProfilePicture,

                };
                return rv;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override Task<bool> Remove(Document item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override async Task RemoveById(int id, ClaimsPrincipal user)
        {
            try
            {
                var document=await _ctx.Documents.FirstOrDefaultAsync(x=>x.Id==id);
                if (document==null)
                {
                    throw new ArgumentNullException(nameof(document));
                }
                _ctx.Documents.Remove(document);
                await _ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        public override async Task<bool> Update(int id, Document newData, ClaimsPrincipal user)
        {
            try
            {
                var document = await _ctx.Documents.FirstOrDefaultAsync(x=>x.Id==id);
                if (document==null)
                {
                    return false;
                }
                if (!string.IsNullOrEmpty(newData.Description))
                {
                    document.Description = newData.Description;
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
