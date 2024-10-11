using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("1","Revolt","EV",2000);

            Console.WriteLine(bike.ToString());
            Console.ReadLine(); 
        }
    }
}
