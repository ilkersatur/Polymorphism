using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_III
{
    internal class TamZamanlı : Personel
    {
        public TamZamanlı(double maas, double satışmıktarı)
        {
            Maas = maas;
            SatisMiktari = satışmıktarı;

            Hesapla1();
            Hesapla();
        }
        public override double Hesapla()
        {
            if (SatisMiktari < 50000)
            {
                Prim = Maas * 0.1;
                return Toplam = Maas + Prim;
            }
            else if (SatisMiktari > 50000 && SatisMiktari < 150000)
            {
                Prim = Maas * 0.2;
                return Toplam = Maas + Prim;
            }
            else
            {
                Prim = Maas * 0.3;
                return Toplam = Maas + Prim;
            }
        }

        protected override void Hesapla1()
        {
            if (SatisMiktari < 50000)
                Prim = SatisMiktari * 0.01;
            else if (SatisMiktari > 50000 && SatisMiktari < 150000)
                Prim = SatisMiktari * 0.02;
            else
                Prim = SatisMiktari * 0.03;

            Maas = Maas + Prim;
        }
    }
}
