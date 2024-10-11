using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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

        //public void DisplayElectricBikeInfo()
        //{
        //    var bikeinfo = DisplayBikeInfo();
        //    Console.WriteLine($"{bikeinfo},BatteyCapacity:{FuelTankCapacity},FuelType:{EngineCapacity}");

        //}

        public override string DisplayBikeInfo()
        {
            var bikeinfo = base.DisplayBikeInfo();
            return ($"{bikeinfo},FuelTankCapacity:{FuelTankCapacity},EngineCapacity:{EngineCapacity}");
        }
    }
}
