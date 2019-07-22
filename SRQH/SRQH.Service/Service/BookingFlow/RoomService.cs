using SRQH.Business.BookingFlow.Interface;
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
        private readonly IRoomBusiness _roomBusiness;

        public RoomService(IRoomRepository roomRepository, IRoomBusiness roomBusiness)
        {
             _roomRepository = roomRepository;
            _roomBusiness = roomBusiness;
        }

        public void CreateManyRooms(RoomType roomType, int quantityOfRooms, int quantityOfRoomsAvailable)
        {
            // TO DO: Validações

            List<Room> rooms = new List<Room>();

            rooms = _roomBusiness.CreateManyRoomsBusiness(roomType, quantityOfRooms, quantityOfRoomsAvailable);

            foreach(var room in rooms)
            {
                _roomRepository.Create(room);
            }
        }

        public List<Room> ListRooms()
        {
            return _roomRepository.Get();
        }

        public void CreateRoom(RoomType roomType, bool availabilite)
        {
            _roomRepository.Create(new Room(roomType, availabilite, false));
        }
    }
}
