using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_I
{
    internal class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public double Fiyat { get; set; }
        public override string ToString()
        {
            return $"Kitap Adı- {KitapAdi}\nKitapId- {KitapID}\nFiyat-{Fiyat}";
        }
    }
}
