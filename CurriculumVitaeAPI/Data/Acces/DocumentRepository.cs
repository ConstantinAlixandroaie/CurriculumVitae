using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IDocumentRepository : IRepository<Document>
    {

    }
    public class DocumentRepository : Repository<Document>, IDocumentRepository
    {
        public DocumentRepository(MyCVDbContext ctx,ILogger<DocumentRepository> logger):base(ctx, logger)
        {

        }

        public override Task<Document> Add(Document item)
        {
            throw new NotImplementedException();
        }

        public override Task<Document> Delete(Document item)
        {
            throw new NotImplementedException();
        }

        public override Task<Document> DeleteById(int id)
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

        public override Task<Document> Update(int id, Document newData)
        {
            throw new NotImplementedException();
        }
    }
}
