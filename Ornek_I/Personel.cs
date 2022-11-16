using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_I
{
    internal class Personel
    {
        public int PerID { get; set; }
        public string AdSoyad { get; set; }
        public override string ToString()
        {
            return $"PersonelID- {PerID}\nAdSoyad- {AdSoyad}";
        }
    }
}
