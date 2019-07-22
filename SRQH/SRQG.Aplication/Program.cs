using SRQG.Aplication.UI;
using SRQH.Domain.Entities.BookingFlow;
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
            BookingService bookingService = new BookingService();

            List<Room> rooms = new List<Room>();
            List<Booking> bookings = new List<Booking>();

            string options = "";

            UserInterface userInterface = new UserInterface();

            //Bild Rooms

            //Bild a list of all enum values
            List<RoomType> roomTypes = Enum.GetValues(typeof(RoomType)).Cast<RoomType>().ToList();

            int roomsQuantity = 0;
            int availableRoomsQuantity = 0;
            foreach (var type in roomTypes)
            {
                Console.WriteLine($"Digite a quantidade de quartos {type.ToString()} :");
                roomsQuantity = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Digite a quantidade de quartos {type.ToString()} disponíveis: ");
                availableRoomsQuantity = Int32.Parse(Console.ReadLine());
            }




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

                        userInterface.LoadRoonsOptions(rooms);

                        roomOptions = Console.ReadLine();

                        while (roomOptions != "0")
                        {
                            switch (roomOptions)
                            {
                                //Room add
                                case "1":

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
