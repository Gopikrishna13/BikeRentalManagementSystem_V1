using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class BikeManager
    {
         public static int Ng{ get; set; }

        public List<Bike> BikeList = new List<Bike>();

        public List <Bike> NewList=new List<Bike>();

        public void CreateBike()
        {
            Console.Write("Enter ID:");
            string Id=Console.ReadLine();

           // bool chkId=checkId(Id.ToLower());
           
                Console.Write("Enter Brand:");
                string brand = Console.ReadLine();

                Console.Write("Enter Model:");
                string model = Console.ReadLine();

                Console.Write("Enter Rental:");
                decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Choose an option: 1.Electric \n 2.Petrol:");
            int option=int.Parse(Console.ReadLine());
            Bike bike;
            if(option==1) 
                {
                Console.Write("Enter Battery Capacity:");
                string battery=Console.ReadLine();

                Console.Write("Enter Fuel Type:");
                string fuel=Console.ReadLine();
                bike=new ElectricBike(Id, brand, model,price, battery, fuel);
                bike.DisplayBikeInfo();

                }
                else
                {
                Console.Write("Enter Fuel Tank Capacity:");
                string fuel = Console.ReadLine();

                Console.Write("Enter Engine:");
                string engine = Console.ReadLine();
                bike = new PetrolBike(Id, brand, model, price, fuel, engine);
                bike.DisplayBikeInfo();

            }
                
               // Bike bike = new Bike(Id, brand, model, price);
                BikeList.Add(bike);
                Console.WriteLine("Data added");

            
            

          

        }



        //public bool checkId(string Id)
        //{
        //    var result = BikeList.Any(x => x.BikeId == Id);
        //    return result;

        //}



        //public void DeleteBike()
        //{
        //    Console.Write("Enter ID to delete :");
        //    string Id = Console.ReadLine();

        //    var bikeremove = BikeList.Single(x => x.BikeId.ToLower() == Id.ToLower());
        //    BikeList.Remove(bikeremove);
        //    Console.WriteLine("Deleted");

        //}

        public void ReadBikes()
        {
            foreach (var bike in BikeList)
            {
                Console.WriteLine(bike);
            }

        }

        //public void UpdateBike()
        //{
        //    Console.Write("Enter ID to Update :");
        //    string Id = Console.ReadLine();

        //    bool chkId = checkId(Id.ToLower());
        //    if (chkId)
        //    {
        //        Console.Write("Enter Brand:");
        //        string brand = Console.ReadLine();

        //        Console.Write("Enter Model:");
        //        string model = Console.ReadLine();

        //        Console.Write("Enter Rental:");
        //        decimal rental = decimal.Parse(Console.ReadLine());

        //        var result = BikeList.Single(x => x.BikeId.ToLower() == Id.ToLower());
        //        BikeList.Remove(result);

        //        Bike bike = new Bike(Id, brand, model, rental);
        //        BikeList.Add(bike);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid ID");
        //    }

        //}
    }
}
