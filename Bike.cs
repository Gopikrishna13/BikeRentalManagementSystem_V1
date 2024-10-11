using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRentalManagement
{
    internal class Bike
    {
        private string BikeId {  get; set; }
        private string Brand { get; set; }

        private string Model {  get; set; }

        private decimal RentalPrice {  get; set; }
        public List <Bike> newBike { get; set; }=new List<Bike>();

        public Bike(string bikeId, string brand, string model, decimal rentalPrice)
        {

            this.BikeId = bikeId;
            this. Brand = brand;
            this.Model = model;
            this.RentalPrice = rentalPrice;

        //    var bike = 
        //    {
        //        BikeId =   this.BikeId,
        //        Brand = brand,
        //        Model = model,
        //        RentalPrice = rentalPrice
        //    };

        //}

      
        public override string ToString()
        {
            return  $"bikeId : {BikeId}, brand: {Brand}, model: {Model}, rentalPrice: {RentalPrice}";
        }

        public static List<Bike> NumberOfPlayersInOfflineGame
        {
            get
            {
                //return numberOfPlayersInOfflineGame;
            }
            set
            {
       
            }
        }






    }


}
