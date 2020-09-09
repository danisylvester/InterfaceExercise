using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVehicles = new List<IVehicle>();

            var tacoma = new Truck() { 
                CompanyName = "Toyota", HeadQuarterLocation = "Japan", Model = "Tacoma", 
                IsUsedCar = true, Color = "Black", NumberOfMiles = 100000, TruckBedSize = 6, MaxTowLbs = 7000, HasChangedGears = false };
            var subaru = new SUV() { CompanyName = "Subaru", HeadQuarterLocation = "Japan", Model = "Outback", 
                IsUsedCar = false, Color = "blue", NumberOfMiles = 0, HasHatchBack = true, RowsOfSeats = 2, HasChangedGears = false };
            var civic = new Car() { CompanyName = "Honda", HeadQuarterLocation = "Japan", Model = "Civic", 
                IsUsedCar = true, Color = "Silver", NumberOfMiles = 150000, HasTrunk = true, IsLuxury = false, HasChangedGears = false };
            
            myVehicles.Add(tacoma);
            myVehicles.Add(subaru);
            myVehicles.Add(civic);

            foreach(var vehicle in myVehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }


        }
    }
}
