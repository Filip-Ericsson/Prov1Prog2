using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Customers
    {
        private int money; //skapade denna int variabel eftersom en besökare måste ha pengar att köpa böker med
        public string name; //Vem vill inte ha ett namn
        private string categoryIntrest; //Olika besökare kan ha olika intressen vilket gör att de söker olika kategorier av böcker
        private string booksAlreadyOwned; // Om en kund redan äger en bok kommer hen inte att köpa den
        Random gen = new Random();

        private List<int> customer = new List<int>(); //En lista på hur många kunder som finns i butiken 


        public Customers()
        {
            //Här skulle namn, pängar, categoryIntrest och bookAlreadyOwned slumpas
        }

        public void AddCustomers(int addCustomers) // denna metod taremot användar input och adderar mängden besökare som användaren önskar 
        {
            customer.Add(addCustomers);

            Console.WriteLine("There are now " + customer+" customers in the store.");
        }

    }
}
