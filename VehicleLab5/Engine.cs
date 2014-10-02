using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Engine : Component
    {
        // Store engines horsepower
        private int horsePower;
        // Store current torque - to pass to driveshaft or transmission
        public int torque;
        // Store current fuel consumption rate - based on user input -
        public int fuelConsumption;

        public Engine(int _horsePow) :
            base("Engine", false)
        {
            horsePower = _horsePow;
            torque = 1;
            fuelConsumption = 0;
        }
        public override void Update()
        {
            torque = horsePower * fuelConsumption;
        }
        public void Accelerate(int _gasUse)
        {
            fuelConsumption = _gasUse;
        }
        public int GetTorque()
        {
            return torque;
        }
    }
}
