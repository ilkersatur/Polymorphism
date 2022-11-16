using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_II
{
    internal class Koni : Silindir
    {
        public override double Hesapla()
        {
            return base.Hesapla() / 3;
        }
        //public override string ToString()
        //{
        //    return $"{Hesapla(r,h)}";
        //}
    }
}
