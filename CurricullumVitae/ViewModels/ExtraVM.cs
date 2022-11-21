namespace CurricullumVitae.Models
{
    public class ExtraVM : IUIObject
    {
        
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IUIObject MakeNew()
        {
            return new ExtraVM { Id = Id, Title = Title, Content = Content };
        }

       public void UpdateFrom(IUIObject obj)
        {
            var q= obj as ExtraVM;
            Title = q.Title;
            Content = q.Content;
        }
    }
}
