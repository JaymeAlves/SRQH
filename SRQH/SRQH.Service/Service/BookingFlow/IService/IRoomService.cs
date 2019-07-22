using SRQH.Domain.Entities.BookingFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Service.Service.BookingFlow.IService
{
    public interface IRoomService
    {
        void CreateManyRooms(RoomType roomType, int quantityOfRooms, int quantityOfRoomsAvailable);
        List<Room> ListRooms();
        void CreateRoom(RoomType roomType, bool availabilite);
    }
}
