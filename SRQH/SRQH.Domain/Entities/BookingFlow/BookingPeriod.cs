using SRQH.Domain.Entities.Base;
using System;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class BookingPeriod : BaseEntity
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public BookingPeriod(DateTime checkIn, DateTime checkOut) : base()
        {
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
    }
}
