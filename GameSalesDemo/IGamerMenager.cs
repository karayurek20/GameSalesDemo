using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo
{
    interface IGamerMenager
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
