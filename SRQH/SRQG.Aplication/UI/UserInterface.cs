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
            Console.WriteLine("1. Alterar quantidade de quartos");
            Console.WriteLine("0. Sair");

        }


    }
}
