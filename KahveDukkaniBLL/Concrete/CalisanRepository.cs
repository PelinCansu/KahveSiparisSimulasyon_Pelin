using KahveSiparisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveDukkaniBLL.Concrete
{
    public class CalisanRepository
    {
        public List<Calisan> Calisanlar()
        {
            return KahveDukkaniDataAccess.Context.KahveDukkaniEntities.Calisanlar = new List<Calisan>()
            {
                new Calisan() {AdSoyad="Ahmet Ahmet"},
                new Calisan() {AdSoyad="Ayşe Ayşe"},
                new Calisan() {AdSoyad="Cemre Cemre"},
                new Calisan() {AdSoyad="Ali Ali"},
                new Calisan() {AdSoyad="Emre Emre"}
            };
        }
    }
}
