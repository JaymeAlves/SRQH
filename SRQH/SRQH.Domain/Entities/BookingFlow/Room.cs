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
        public bool Booked { get; set; }

        public Room(RoomType roomType, bool available, bool booked)
        {
            RoomType = roomType;
            Available = available;
            Booked = booked;
        }
    }
}
