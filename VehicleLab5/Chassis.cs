using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Chassis : Component
    {
        // Body weight in kilograms
        public float weight;
        // Material that the chassis is made out of
        public string material;

        public Chassis(int _weight = 1, string _mat = "Iron") :
            base("Chassis", true)
        {
            weight = _weight;
            material = _mat;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
