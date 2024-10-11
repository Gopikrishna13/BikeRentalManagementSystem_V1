using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class ElectricBike:Bike
    {
        public string Batterycapacity {  get; set; }    
        public string FuelType {  get; set; }

        public ElectricBike(string Id,string brand,string model,decimal price, string Batterycapacity, string FuelType):base(Id, brand, model, price)
        {
            this.Batterycapacity = Batterycapacity;
            this.FuelType = FuelType;
        }

        public void DisplayElectricBikeInfo()
        {
            var bikeinfo = DisplayBikeInfo();
            Console.WriteLine($"{bikeinfo},BatteyCapacity:{Batterycapacity},FuelType:{FuelType}");

        }
    }
}
