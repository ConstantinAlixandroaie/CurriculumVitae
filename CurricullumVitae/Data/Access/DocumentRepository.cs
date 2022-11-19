using CurricullumVitae.Models;
using System.Security.Claims;

namespace CurricullumVitae.Data.Access
{
    public interface IDocumentRepository : IRepository<Document>
   
    public class DocumentRepository:Repository<Document>,IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext ctx):base(ctx)
        {

        }

        public override Task<Document> Add(Document item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<IEnumerable<Document>> Get(bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<Document> GetById(int id, bool asNoTracking = false)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Remove(Document item, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task RemoveById(int id, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }

        public override Task<bool> Update(int id, Document newData, ClaimsPrincipal user)
        {
            throw new NotImplementedException();
        }
    }
}
