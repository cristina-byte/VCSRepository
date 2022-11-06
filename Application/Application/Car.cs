using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    internal class Car
    {
        string brand;
        string price;

        public string Brand { get => brand; set => brand = value; }
        public string Price { get => price; set => price = value; }

       public void printCar()
        {
            Console.WriteLine(brand);
            Console.WriteLine(price);

        }
    }
}
