using KahveSiparisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniBLL.Concrete
{
    public class EkstraRepository
    {
        public List<EkstraMalzeme> EkstraMalzemeler()
        {
            return KahveDukkaniDataAccess.Context.KahveDukkaniEntities.EkstraMalzemeler = new List<EkstraMalzeme>()
            {
              new EkstraMalzeme() {EkstraMalzemeAdi= "Süt", EklenmeSuresi=1, EkstraUcreti=2},
              new EkstraMalzeme() {EkstraMalzemeAdi= "Şurup", EklenmeSuresi=2, EkstraUcreti=3},
              new EkstraMalzeme() {EkstraMalzemeAdi= "Karamel", EklenmeSuresi=3, EkstraUcreti=5}

            };

        }

    }
}
