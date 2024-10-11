using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class BikeManager
    {
        public List <Bike> BikeList=new List<Bike>();
     

        public void CreateBike()
        {
            Console.Write("Enter ID:");
            string Id=Console.ReadLine();

            //bool chkId=checkId(Id.ToLower());

            Console.Write("Enter Brand:");
            string brand=Console.ReadLine();

            Console.Write("Enter Model:");
            string model=Console.ReadLine();

            Console.Write("Enter Rental:");
            decimal price=decimal.Parse(Console.ReadLine());

            Bike bike=new Bike(Id,brand,model,price);
            BikeList.Add(bike);
            Console.WriteLine("Data added");

        }



        //public bool checkId(string Id)
        //{
        //    var result=BikeList.Any(x=>x.BikeId==Id);

        //}

        public void DeleteBike()
        {
            

        }

        public void ReadBikes()
        {

        }

        public void UpdateBike()
        {

        }
    }
}
