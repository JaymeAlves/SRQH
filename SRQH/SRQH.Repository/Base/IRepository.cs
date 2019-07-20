using System;
using System.Collections.Generic;

namespace SRQH.Repository.Base
{
    public interface IRepository<T>
    {
        T Get(int id);
        T Get(Guid guid);
        List<T> Get();
        List<T> Get(int skip, int take);
        void Create(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
