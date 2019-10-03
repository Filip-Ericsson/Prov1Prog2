using System;
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

            Customers customers = new Customers();

            Console.WriteLine("Add more customers to the store? \n 1. Yes \n 2. No");
            if(Console.Read() == 1)
            {
                Console.WriteLine("How manny customers?");
                customers.AddCustomers(Console.Read());
            }
            else
            {
                Console.WriteLine("Ok lets not do that then");
            }

            

            Book.PrintInfo();

            Console.WriteLine(Book.Evaluate());

            Console.ReadLine();
        }
    }
}
