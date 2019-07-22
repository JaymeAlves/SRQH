using SRQH.Business.BookingFlow.Interface;
using SRQH.Domain.Entities.BookingFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Business.BookingFlow
{
    public class RoomBusiness : IRoomBusiness
    {
        public List<Room> CreateManyRoomsBusiness(RoomType roomType, int quantityOfRooms, int quantityOfRoomsUnavailable)
        {

            List<Room> rooms = new List<Room>();
            Room room;

            for (int i = 0; i < quantityOfRooms; i++)
            {
                if (i <= quantityOfRoomsUnavailable)
                {
                    room = new Room(roomType, true, false);
                }
                else
                {
                    room = new Room(roomType, true, false);
                }

                rooms.Add(room);
            }

            return rooms;   
        }
    }
}
