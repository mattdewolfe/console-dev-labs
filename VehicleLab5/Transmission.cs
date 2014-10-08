using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Transmission : Component
    {
        private float[] gearRatios;
        private int currentGear;
        private int numGears;
        public float force;
        private Engine engine;
        
        // Requires an engine to be attached to
        public Transmission(Engine _engine, int _numGears = 2) :
            base ("Transmission", false)
        {
            engine = _engine;
            numGears = _numGears;
            currentGear = 0;
            gearRatios = new float[numGears];

            for (int i = 0; i < numGears; i++)
            {
                gearRatios[i] = 1.0f;
            }
        }
        public override void Update()
        {
            force = (gearRatios[currentGear] * engine.GetTorque());
        }
        // Get the ratio of the current gear
        public float GetRatio()
        {
            return gearRatios[currentGear];
        }
        // Increase engine gear - if possible
        public void GearUp()
        {
            if (currentGear < numGears)
                currentGear++;
        }
        // Decrease engine gear - if possible
        public void GearDown()
        {
            if (currentGear > 0)
                currentGear--;
        }
        // Set the ratio of a given gear
        public void SetGearRatio(int _gear, float _ratio)
        {
            // If the target gear is outside the range of this transmission
            if (_gear > numGears || _gear < 0)
            {
                // return from function
                return;
            }
            // Otherwise set the ratio of the target gear
            else
            {
                gearRatios[_gear] = _ratio;
            }
        }
    }
}
