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

                        userInterface.LoadRoonsOptions(roomService.ListRooms());

                        roomOptions = Console.ReadLine();

                        while (roomOptions != "0")
                        {
                            switch (roomOptions)
                            {
                                //Room add
                                case "1":
                                    Console.WriteLine("Escolha o tipo de quarto: ");

                                    int i = 1;

                                    foreach (var type in roomTypes)
                                    {
                                        Console.WriteLine($"{i}. {type.ToString()}");

                                        i++;
                                    }

                                    int typePosition = Int32.Parse( Console.ReadLine() );

                                    Console.WriteLine("O quarto disponível: (Y/N)");

                                    bool enable = false;

                                    if ("Y".Equals(Console.Read()) || "y".Equals(Console.Read()))
                                        enable = true;

                                    roomService.CreateRoom(roomTypes.ElementAt(typePosition - 1), enable);
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
