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
        public ProductManager(CrossCuttingConsernsFactory crossCuttingConsernsFactory) //bunun sayesinde cccfactory'si abstract edinen tüm classlar gönderilip çağrılabilir
        {
            _crossCuttingConsernsFactory = crossCuttingConsernsFactory;
        }
        public void GetAll()
        {
            //ek kodlar olabilir
            _crossCuttingConsernsFactory.CreateLog().Log("Giris");
            _crossCuttingConsernsFactory.CreateCache().Cache("#ahsjd1280djaok...");

            Console.WriteLine("Here:...");
        }
    }
}
