﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Books Book = new Books();

            Book.PrintInfo();

            Console.WriteLine(Book.Evaluate());

            Console.ReadLine();
        }
    }
}
