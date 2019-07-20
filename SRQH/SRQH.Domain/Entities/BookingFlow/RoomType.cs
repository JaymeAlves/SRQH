using SRQH.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class RoomType : BaseEntity
    {
        public string Description { get; set; }
        public float Cost { get; set; }

        public RoomType(string description, float cost) : base()
        {
            Description = description;
            Cost = cost;
        }
    }
}
