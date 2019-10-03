using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Customers
    {
        private int money;
        public string name;
        private string categoryIntrest;
        private string booksAlreadyOwned;
        Random gen = new Random();

        private List<int> customer = new List<int>();


        public Customers()
        {

        }

        public void AddCustomers(int addCustomers)
        {
            customer.Add(addCustomers);

            Console.WriteLine("There are now " + customer+" customers in the store.");
        }

    }
}
