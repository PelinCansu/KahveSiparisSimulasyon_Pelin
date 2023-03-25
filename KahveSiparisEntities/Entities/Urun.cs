using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisEntities.Entities
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public int BegenilmeOrani { get; set; }
        public byte HazirlanmaSuresi { get; set; }
        public decimal UrunFiyat { get; set; }

        public override string ToString()
        {
            return $"Ürün: {UrunAdi}, Süre: {HazirlanmaSuresi}, Fiyat: {UrunFiyat}";
        }
    }
}
