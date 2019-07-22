using SRQH.Domain.Entities.BookingFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Business.BookingFlow.Interface
{
    public interface IRoomBusiness
    {
        List<Room> CreateManyRoomsBusiness(RoomType roomType, int quantityOfRooms, int quantityOfRoomsUnavailable);
    }
}
