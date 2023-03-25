using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisEntities.Entities
{
    public class Siparis
    {
        EkstraMalzeme ekstraMalzeme = new EkstraMalzeme();
        public Urun Urun { get; set; }
        public EkstraMalzeme EkstraMalzeme { get; set; }

        public byte Adet { get; set; }

        public string ToplamFiyat
        {
            get
            {
                return ((Adet * Urun.UrunFiyat) + (Adet * EkstraMalzeme.EkstraUcreti)).ToString();
            }

        }

        public int ToplamSure
        {
            get
            {
                return ((Urun.HazirlanmaSuresi) + (EkstraMalzeme.EklenmeSuresi));
            }

        }
    }
}
