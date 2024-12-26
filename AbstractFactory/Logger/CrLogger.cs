﻿using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    internal class CrLogger : Logging
    {
        public override void Log(string message)
        {
            Console.WriteLine("Logged with CrLogger", message);
        }
    }
}