using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo
{
    class BaseGameMenager : IGamerMenager,IGameCheckMenager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added to your game list : "+gamer.GamerFirtName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Deleted to your game list : " + gamer.GamerFirtName);
        }

        public bool GamersCheck(Gamer gamer)
        {
            throw new NotImplementedException();
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Updated to your game list : " + gamer.GamerFirtName);
        }
    }
}
