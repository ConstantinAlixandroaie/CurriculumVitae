namespace CurricullumVitae.Models
{
    public class ProfilePictureVM : IUIObject
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IUIObject MakeNew()
        {
            return new ProfilePictureVM { Id = Id, ImageUrl = ImageUrl, DocumentId = DocumentId, Document = Document };
        }

        public void UpdateFrom(IUIObject obj)
        {
            var q = obj as ProfilePictureVM;
            ImageUrl= q.ImageUrl;
            Document= q.Document;
            DocumentId= q.DocumentId;
        }
    }
}
