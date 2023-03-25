using KahveSiparisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniBLL.Concrete
{
    public class KahveRepository
    {
        public List<Urun> Urunler()
        {
            return KahveDukkaniDataAccess.Context.KahveDukkaniEntities.Urunler= new List<Urun>()
            {
              new Urun() {UrunAdi="Latte", BegenilmeOrani=10, HazirlanmaSuresi=5, UrunFiyat=50 },
              new Urun() {UrunAdi="Esprosso", BegenilmeOrani=9, HazirlanmaSuresi=4, UrunFiyat=40 },
              new Urun() {UrunAdi="Americano", BegenilmeOrani=8, HazirlanmaSuresi=3, UrunFiyat=30},
              new Urun() {UrunAdi="Türk Kahvesi", BegenilmeOrani=7, HazirlanmaSuresi=4, UrunFiyat=20 }


            };
        }

    }
}
