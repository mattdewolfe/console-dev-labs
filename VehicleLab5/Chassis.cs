using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Chassis : Component
    {
        // Material that the chassis is made out of
        public string material;

        public Chassis(string _mat = "Iron") :
            base("Chassis", true)
        {
            material = _mat;
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
