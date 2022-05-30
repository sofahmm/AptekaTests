﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AptekaTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string expenc = Drug.ExpensiveDrug();
            Console.WriteLine(expenc);
            var i = Drug.SortByOrder();
            var ii = Drug.SortDescOrder();

            foreach (var l in i)
            {
                Console.WriteLine(l.Name + l.Price);
            }

            foreach (var l in ii)
            {
                Console.WriteLine(l.Name + l.Price);
            }

            Console.ReadKey();
        }
    }
}
