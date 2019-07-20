using SRQH.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRQH.Repository.Base
{
    public abstract class Repository<T> : IRepository<T> where T : IBaseEntity
    {
        private static List<T> _data;
        private static object _syncObj = new object();

        public Repository()
        {
            if (_data == null)
            {
                lock (_syncObj)
                {
                    if (_data == null)
                    {
                        _data = new List<T>();
                    }
                }
            }
        }

        public void Create(T obj)
        {
            _data.Add(obj);
        }

        public void Delete(T obj)
        {
            _data.Remove(obj);
        }

        public T Get(int id)
        {
            return _data.Find(x => x.Id == id);
        }

        public T Get(Guid guid)
        {
            return _data.Find(x => x.Guid == guid);
        }

        public List<T> Get()
        {
            return _data;
        }

        public List<T> Get(int skip, int take)
        {
            return _data.Skip(skip).Take(take).ToList();
        }

        public void Update(T obj)
        {
            T old = Get(obj.Guid);
            Delete(old);
            Create(obj);
        }
    }
}
