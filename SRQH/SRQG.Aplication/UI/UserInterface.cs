using SRQH.Domain.Entities.BookingFlow;
using System;
using System.Collections.Generic;
using System.Text;

namespace SRQG.Aplication.UI
{
    public class UserInterface
    {


        public void LoadMenu()
        {
            Console.WriteLine("*** Hotel ***");
            Console.WriteLine("1. Opções de Quartos");
            Console.WriteLine("0. Sair");
            //Console.WriteLine("");
        }

        public void LoadRoonsOptions(List<Room> list)
        {
            Console.WriteLine("*** Quartos ***");
            Console.WriteLine($"Quantidade de quartos: {list.Count}");
            Console.WriteLine("1. Adicionar quarto");
            Console.WriteLine("0. Sair");

        }

        public void RequestRoomQuantity(RoomType type)
        {
            Console.WriteLine($"Digite a quantidade de quartos {type.ToString()} :");
        }

        public void RequestAvailableRoomQuantity(RoomType type)
        {
            Console.WriteLine($"Digite a quantidade de quartos {type.ToString()} disponíveis: ");
        }

        public void RequestRoomType()
        {
            Console.WriteLine("Escolha o tipo de quarto: ");
        }

        public void ListRoomType(List<RoomType> roomTypes)
        {
            int i = 1;

            foreach (var type in roomTypes)
            {
                Console.WriteLine($"{i}. {type.ToString()}");

                i++;
            }
        }

        public void RequestRoomAvailability()
        {
            Console.WriteLine("O quarto está disponível (Y/N): ");
        }

        public void RequestRoomTypeToActive()
        {
            Console.WriteLine("Escolha um tipo de quarto ativar:");
        }
    }
}
