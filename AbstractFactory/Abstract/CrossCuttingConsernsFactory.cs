using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class Factory1
    {
        public abstract Logging CreateLog();
        public abstract Caching CreateCache();
    }
}
