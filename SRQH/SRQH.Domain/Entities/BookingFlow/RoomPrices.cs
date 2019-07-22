using SRQH.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class RoomPrices : BaseEntity
    {
        public float Value { get; set; }

        public RoomPrices   (RoomType roomType)
        {
            if("SINGLE".Equals(roomType))
            {
                Value = 230;
            }else if("STANDARD".Equals(roomType))
            {
                Value = 230;
            }
            else if ("LUXO".Equals(roomType))
            {
                Value = 230;
            }
        }
    }
}
