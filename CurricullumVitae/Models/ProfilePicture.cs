﻿namespace CurricullumVitae.Models
{
    public class ProfilePicture : IUIObject
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IUIObject MakeNew()
        {
            return new ProfilePicture { Id = Id, ImageUrl = ImageUrl, DocumentId = DocumentId, Document = Document };
        }

        public void UpdateFrom(IUIObject obj)
        {
            var q = obj as ProfilePicture;
            ImageUrl= q.ImageUrl;
            Document= q.Document;
            DocumentId= q.DocumentId;
        }
    }
}
