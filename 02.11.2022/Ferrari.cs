using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._11._2022
{
    internal class Ferrari :Araba
    {
        public override void Sur() //diğer classların aynı isimli metodunu override yaptık
        {
            Console.WriteLine("Ferrari sür");
        }
    }
}
