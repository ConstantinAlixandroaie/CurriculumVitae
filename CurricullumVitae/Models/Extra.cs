namespace CurricullumVitae.Models
{
    public class Extra : IDbObject
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IDbObject MakeNew()
        {
            return new Extra { Id = Id, Title = Title, Content = Content };
        }

       public void UpdateFrom(IDbObject obj)
        {
            var q= obj as Extra;
            Title = q.Title;
            Content = q.Content;
        }
    }
}
