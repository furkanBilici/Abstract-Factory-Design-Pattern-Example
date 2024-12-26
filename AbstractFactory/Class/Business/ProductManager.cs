using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class.Business
{
    public class ProductManager
    {
        CrossCuttingConsernsFactory _crossCuttingConsernsFactory;
        Logging _logging;
        Caching _caching;
        public ProductManager(CrossCuttingConsernsFactory crossCuttingConsernsFactory) //bunun sayesinde cccfactory'si abstract edinen tüm classlar gönderilip çağrılabilir
        {
            _crossCuttingConsernsFactory = crossCuttingConsernsFactory;
            _logging = _crossCuttingConsernsFactory.CreateLog();
            _caching=_crossCuttingConsernsFactory.CreateCache();
        }
        public void GetAll()
        {
            //ek kodlar olabilir
            _logging.Log("Giris");
            _caching.Cache("#ahsjd1280djaok...");

            Console.WriteLine("Here:...");
        }
    }
}
