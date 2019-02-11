using System.Collections.Generic;

namespace CAMM.DataAccess.Interface
{
    public interface IDataProvider<T>
    {
        T GetById(int id);

        T GetById(string name);

        IEnumerable<T> Find(T entity);

        T Update(T newEntity);

        T Add(T entity);

        int Remove(int id);

        int Remove(string id);

        IEnumerable<T> GetAll();

        void SubmitChanges();
    }
}
