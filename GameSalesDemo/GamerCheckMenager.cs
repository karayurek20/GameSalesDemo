using System;
using System.Collections.Generic;
using System.Text;

namespace GameSalesDemo
{
    class GamerCheckMenager : IGameCheckMenager
    {
        public bool GamersCheck(Gamer gamer)
        {
            MernisServiceReference1.KPSPublicSoapClient client = new MernisServiceReference1.KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(gamer.GamerNationalId, gamer.GamerFirtName.ToUpper, gamer.GamerLastName.ToUpper, gamer.BirthDay.Year);
        }
    }
}
