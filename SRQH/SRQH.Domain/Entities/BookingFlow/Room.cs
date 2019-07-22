using SRQH.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class Room : BaseEntity
    {
        public RoomType RoomType { get; set; }
        public bool Available { get; set; }
        public int MyProperty { get; set; }

        public Room()
        {

        }
        
    }
}
