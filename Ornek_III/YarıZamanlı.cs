using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_III
{
    internal class YarıZamanlı : Personel //control + . yapınca abstrack sınıfı uygula menü açılır
    {
        public YarıZamanlı(double saat, double saatücreti, double satışmiktarı)
        {
            Saat = saat;
            SaatÜcreti = saatücreti;
            SatisMiktari = satışmiktarı;

            Hesapla1();
            Hesapla();
        }
        public double Saat { get; set; }
        public double SaatÜcreti { get; set; }
        public override double Hesapla()
        {
            Maas = Saat * SaatÜcreti;
            return Toplam = Maas + (SatisMiktari * 0.1);
        }

        protected override void Hesapla1()
        {
            Prim = SatisMiktari * 0.1;
            Maas = (Saat * SaatÜcreti) + Prim;
        }
    }
}
