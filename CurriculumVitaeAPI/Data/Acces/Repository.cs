using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public abstract class Repository<T> : IRepository<T> where T : class, IDbObject
    {
        protected MyCVDbContext _ctx;
        protected readonly ILogger _logger;


        public Repository(MyCVDbContext ctx, ILogger<Repository<T>> logger)
        {
            _ctx = ctx;
            _logger = logger;

        }
        public abstract Task<IEnumerable<T>> Get(bool asNoTracking = false);
        public abstract Task<T> GetById(int id, bool asNoTracking = false);
        public abstract Task<T> Add(T item);
        public abstract Task<T> Delete(T item);
        public abstract Task<T> DeleteById(int id);
        public abstract Task<T> Update(int id, T newData);
    }
}
