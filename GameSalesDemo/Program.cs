using System;

namespace GameSalesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { GamerFirtName = "Mehmet Can", GamerLastName = "Karayürek", GamerId = 20, GamerNationalId = "34045313856" ,BirthDay=new DateTime(1998,06,30)};
            BaseGameMenager gameMenager = new BaseGameMenager();
            gameMenager.Add(gamer);
            gameMenager.Update(gamer);
           
        }
    }
}
