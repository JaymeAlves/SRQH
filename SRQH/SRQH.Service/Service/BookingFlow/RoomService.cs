using SRQH.Domain.Entities.BookingFlow;
using SRQH.Repository.BookingFlow;
using SRQH.Repository.BookingFlow.Interface;
using SRQH.Service.Service.BookingFlow.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQH.Service.Service.BookingFlow
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
             _roomRepository = roomRepository;
        }

        public void CreateManyRooms(RoomType roomType, int quantityOfRooms, int quantityOfRoomsUnavailable)
        {
            
        }
    }
}
