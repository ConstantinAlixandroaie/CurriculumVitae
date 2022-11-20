namespace CurricullumVitae.Models
{
    public class ProfilePicture : IDbObject
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IDbObject MakeNew()
        {
            return new ProfilePicture { Id = Id, ImageUrl = ImageUrl, DocumentId = DocumentId, Document = Document };
        }

        public void UpdateFrom(IDbObject obj)
        {
            var q = obj as ProfilePicture;
            ImageUrl= q.ImageUrl;
            Document= q.Document;
            DocumentId= q.DocumentId;
        }
    }
}
