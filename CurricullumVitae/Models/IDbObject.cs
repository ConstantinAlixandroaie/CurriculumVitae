namespace CurricullumVitae.Models
{
    public interface IDbObject
    {
        public int Id { get; set; }
        IDbObject MakeNew();
        void UpdateFrom(IDbObject obj);

    }
}
