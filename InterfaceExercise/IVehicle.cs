using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string Model { get; set; }
        public bool IsUsedCar { get; set; }
        public int NumberOfMiles { get; set; }
        public string Color { get; set; }
        public bool HasChangedGears { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();
        public void ChangeGears(bool isChanged);

    }
}
