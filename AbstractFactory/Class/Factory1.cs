using AbstractFactory.Abstract;
using AbstractFactory.Class.Cache;
using AbstractFactory.Class.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    internal class Factory1 : CrossCuttingConsernsFactory
    {
        public override Caching CreateCache()
        {
            //ek işlemler yapıldığı varsayılarak...
            return new MCache();
        }

        public override Logging CreateLog()
        {
            //ek işlemler yapıldığı varsayılarak...
            return new FrLogger();
        }
    }
}
