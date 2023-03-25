using KahveSiparisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniDataAccess.Context
{
    public class KahveDukkaniEntities
    {
        public KahveDukkaniEntities()
        {
            Siparisler = new List<Siparis>();
        }
        public static List<Calisan> Calisanlar { get; set; }
        public static List<Urun> Urunler { get; set; }
        public static List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public static List<Siparis>Siparisler { get; set; }
        public static List<Kasa> Kasalar { get; set; }
    }
}
