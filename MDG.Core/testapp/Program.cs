﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MDG.Core;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.AddInfo("Test log to info.");
            Log.AddInfo("Test log 2 to info.");
            Console.ReadKey();
        }
    }
}
