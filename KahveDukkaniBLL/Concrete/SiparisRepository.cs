using KahveDukkaniDataAccess.Context;
using KahveSiparisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniBLL.Concrete
{
    public class SiparisRepository
    {
        KahveDukkaniEntities db = new KahveDukkaniEntities();

        public void Add(Siparis siparis)
        {
            KahveDukkaniEntities.Siparisler.Add(siparis);
        }

        public List<Siparis> GetAll()
        {
            return KahveDukkaniEntities.Siparisler;
        }

        public Siparis SiparisOlustur(Urun urun,EkstraMalzeme ekstralarMalzeme)
        {
            return new Siparis() { Urun = urun, EkstraMalzeme= ekstralarMalzeme};
        }


    

      
    }
}
