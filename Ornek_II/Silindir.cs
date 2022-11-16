using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_II
{
    internal class Silindir : Daire
    {
        public double h { get; set; }

        public override double Hesapla()
        {
            return base.Hesapla() * h;
        }
        //public override string ToString()
        //{
        //    return $"{Hesapla(r,h)}";
        //}
    }
}
}
