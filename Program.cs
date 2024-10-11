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
            Bike bike1 = new Bike("BIKE_001", "YAMAHA", "mt-15", 10);

            Console.WriteLine(bike1.ToString());
            Console.ReadLine(); 
        }
    }
}
