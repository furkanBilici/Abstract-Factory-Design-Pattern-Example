using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cache
{
    internal class NCache : Caching
    {
        public override void Cache(string data)
        {
            Console.WriteLine("Cached with NCache",data);
        }
    }
}
