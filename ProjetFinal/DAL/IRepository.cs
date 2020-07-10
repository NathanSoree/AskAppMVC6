using Common.TransferObjects;
using System.Collections.Generic;

namespace DAL
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Upsert(T item);
       
    }
}