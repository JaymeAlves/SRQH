using SRQH.Domain.Entities.Base;

namespace SRQH.Domain.Entities.BookingFlow
{
    public class Booking : BaseEntity
    {
        public Customer Customer { get; set; }
        public Room Room { get; set; }
        public BookingPeriod BookingPeriod { get; set; }
        public DiscountRule DiscountRule { get; set; }

        public Booking(Customer customer, Room room, BookingPeriod bookingPeriod, DiscountRule discountRule) : base()
        {
            Customer = customer;
            Room = room;
            BookingPeriod = bookingPeriod;
            DiscountRule = discountRule;
        }
    }
}
