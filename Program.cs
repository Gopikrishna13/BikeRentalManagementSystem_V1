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
            //Bike bike = new Bike("1","Revolt","EV",2000);
            //Bike bike1 = new Bike("BIKE_001", "YAMAHA", "mt-15", 10);

            //Console.WriteLine(bike1.ToString());
            BikeManager manager = new BikeManager();

            bool response = true;

            while (response)
            {
                Console.Write("Bike Rental Management System: \n 1.Add Bikes \n 2.View All Bikes \n 3.Update Bike \n 4.Delete Bike \n 5.Exit \nChoose an Option:");

               
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        manager.CreateBike();
                        break;
                    case 2:
                        manager.ReadBikes();
                        break;

                    case 3://manager.UpdateBike();
                        break;

                    case 4://manager.DeleteBike();
                        break;
                    case 5: 
                        response = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
