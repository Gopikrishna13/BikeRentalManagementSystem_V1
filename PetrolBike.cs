using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class PetrolBike:Bike
    {
        public string FuelTankCapacity {  get; set; }
        public string EngineCapacity {  get; set; }

        public PetrolBike(string Id, string brand, string model, decimal price, string FuelTankCapacity, string EngineCapacity) : base(Id, brand, model, price)
        {
            this.FuelTankCapacity = FuelTankCapacity;
            this.EngineCapacity = EngineCapacity;
        }
    }
}
