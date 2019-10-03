using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Books
    {
        public int price;
        private int rarity, actualValue;
        private string name, category;
        private bool cursed;
        private Random gen = new Random();
        private List<string> names = new List<string>() {"The Jackmans","The Belmonts","The Smithstonians",  "Book of Earth" };
        private List<string> categories = new List<string>() { "Ancient Spells", "History", "Carpentry", "Laws" };


        public Books()
        {
            rarity = gen.Next(1, 10);
            actualValue = gen.Next(10, 100);

            int isCursed = gen.Next(0, 3);
            if (isCursed == 0)
            {
                cursed = true;
            }

            name = names[gen.Next(names.Count)];
            category = categories[gen.Next(categories.Count)];
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name of Book: " + name + "\n" + "Category: "+ category +"\n" +"Rarity: "+ rarity +"\n"+"Price: " + price);

        }

        public int Evaluate()
        {
            int estimate = actualValue * rarity;
            int genDevider = gen.Next(5, 15) / 10;

            return estimate * genDevider;
        }

    }
}
