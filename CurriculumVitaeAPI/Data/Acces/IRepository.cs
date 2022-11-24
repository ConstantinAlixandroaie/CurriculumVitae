using CurricullumVitae.Models;

namespace CurriculumVitaeAPI.Data.Acces
{
    public interface IRepository<T> where T: IDbObject
    {
        Task<IEnumerable<T>> Get(bool asNoTracking=false);
        Task<T> GetById(int id, bool asNoTracking = false);
        Task<T> Add(T item);
        Task<T> Delete(T item);
        Task<T> DeleteById(int id);
        Task<T> Update(int id, T newData);
    }
}
