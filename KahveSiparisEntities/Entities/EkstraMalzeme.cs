using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisEntities.Entities
{
    public class EkstraMalzeme
    {
        public string EkstraMalzemeAdi { get; set; }
        public byte EklenmeSuresi { get; set; }
        public decimal EkstraUcreti { get; set; }

        public override string ToString()
        {
            return $"Ürün: {EkstraMalzemeAdi}, Ek Süre: {EklenmeSuresi}, Ek Ücret: {EkstraUcreti}";
        }

    }
}
