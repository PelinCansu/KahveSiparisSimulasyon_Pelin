using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveSiparisEntities.Entities
{
    public class Calisan
    {
        public string AdSoyad { get; set; }
        public CalisanDurum  CalisanDurum { get; set; }

        public override string ToString()
        {
            return $"{AdSoyad}";
        }
    }
}
