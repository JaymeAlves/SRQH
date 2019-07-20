using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Domain.Entities.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        Guid Guid { get; set; }
        DateTime CreateDate { get; set; }
    }
}
