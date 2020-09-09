using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public int RowsOfSeats { get; set; }
        public bool HasHatchBack { get; set; }
        public string Model { get; set; }
        public bool IsUsedCar { get; set; }
        public int NumberOfMiles { get; set; }
        public string Color { get; set; }
        public string CompanyName { get; set; }
        public string HeadQuarterLocation { get; set; }
        public bool HasChangedGears { get; set; }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is now driving forward");
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now in park . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"The {GetType().Name} is now reversing . . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears.");
            }
        }
    }
}
