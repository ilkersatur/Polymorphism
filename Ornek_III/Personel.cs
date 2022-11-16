using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_III
{
    internal abstract class Personel
    {
        public string PersonelAdi { get; set; }
        public double SatisMiktari { get; set; }
        public double Prim { get; set; }
        public double Maas { get; set; }
        public double Toplam { get; set; }
        public abstract double Hesapla();
        protected abstract void Hesapla1(); //abstract metodların gövdesi olmaz, sadece akrabalar kullanabilir metod
    }
}
