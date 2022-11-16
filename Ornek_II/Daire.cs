using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_II
{
    internal class Daire
    {
        public double r { get; set; }
        public virtual double Hesapla()
        {
            return r * r * Math.PI;
        }
        //public override string ToString()
        //{
        //    return $"{Hesapla(r)}";
        //}
    }
}
}
