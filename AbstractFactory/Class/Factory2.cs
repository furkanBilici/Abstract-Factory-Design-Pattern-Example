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
    internal class Factory2 : CrossCuttingConsernsFactory
    {
        public override Caching CreateCache()
        {
            //ek işlemler yapıldığı varsayılarak...
            return new NCache();
        }

        public override Logging CreateLog()
        {
            //ek işlemler yapıldığı varsayılarak...
            return new CrLogger();
        }
    }
}
