using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class PhysicsBody : Component
    {
        private vec3 velocity;
        private vec3 acceleration;
        private float mass;

        public PhysicsBody(float _mass) :
            base("PhysicsBody", true)
        { 
            mass = _mass;
        }
        // Should actually take in a direction or force
        public void UpdateVelocty(float _torque)
        {
            acceleration.x = _torque / mass;
            velocity = acceleration - velocity;
        }
        public override void Update()
        {
            UpdateVelocty(1);
        }
    }
}
