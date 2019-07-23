using SRQG.Aplication.UI;
using SRQH.Business.BookingFlow;
using SRQH.Domain.Entities.BookingFlow;
using SRQH.Repository.BookingFlow;
using SRQH.Service.Service.BookingFlow;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SRQG.Aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string options = "";

            UserInterface userInterface = new UserInterface();

            //Bild a list of all enum values
            List<RoomType> roomTypes = Enum.GetValues(typeof(RoomType)).Cast<RoomType>().ToList();

            #region Dependencies builds

            #region repositories
            RoomRepository roomRepository = new RoomRepository();

            #endregion

            #region Business
            RoomBusiness roomBusiness = new RoomBusiness();

            #endregion

            #region Services
            RoomService roomService = new RoomService(roomRepository, roomBusiness);

            #endregion

            #endregion

            //#region Build many rooms
            //int roomsQuantity = 0;
            //int availableRoomsQuantity = 0;
            //foreach (var type in roomTypes)
            //{
            //    userInterface.RequestRoomQuantity(type);
            //    roomsQuantity = Int32.Parse(Console.ReadLine());

            //    userInterface.RequestAvailableRoomQuantity(type);
            //    availableRoomsQuantity = Int32.Parse(Console.ReadLine());

            //    roomService.CreateManyRooms(type, roomsQuantity, availableRoomsQuantity);
            //}
            //#endregion

            while (options != "0")
            {
                Console.Clear();

                userInterface.LoadMenu();

                options = Console.ReadLine();

                switch (options)
                {
                    // Room management
                    case "1":
                        string roomOptions = "";

                        while (roomOptions != "0")
                        {
                            Console.Clear();

                            userInterface.LoadRoonsOptions(roomService.ListRooms());

                            roomOptions = Console.ReadLine();

                            switch (roomOptions)
                            {
                                //Room add
                                case "1":
                                    bool enable = false;

                                    userInterface.RequestRoomType();

                                    userInterface.ListRoomType(roomTypes);

                                    int typePosition = Int32.Parse(Console.ReadLine());

                                    userInterface.RequestRoomAvailability();
                                    
                                    string availableRoom = Console.ReadLine();

                                    if (availableRoom.Equals("Y") || availableRoom.Equals("y"))
                                        enable = true;

                                    roomService.CreateRoom(roomTypes.ElementAt(typePosition - 1), enable);
                                    break;

                                //Room maintenance
                                case "2":
                                    userInterface.RequestRoomTypeToActive();

                                    userInterface.ListRoomType(roomTypes);

                                    int typePosition = Int32.Parse(Console.ReadLine());

                                    try
                                    {

                                    }
                                    catch (Exception e)
                                    {

                                        throw e;
                                    }

                                    break;

                                default:
                                    break;
                            }
                        }

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
