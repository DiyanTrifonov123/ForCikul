﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumiraneNaChisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for (int i = 1; i <= 100; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
