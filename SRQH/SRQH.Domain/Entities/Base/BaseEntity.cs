using System;

namespace SRQH.Domain.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime CreateDate { get; set; }

        public BaseEntity()
        {
            Guid = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }
    }
}
