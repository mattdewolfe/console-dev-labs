using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    // Custom struct for vector 3's
    struct vec3
    {
        public float x;
        public float y;
        public float z;
        public vec3(float _x = 0, float _y = 0, float _z = 0)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        // Override - operator
        public static vec3 operator -(vec3 v1, vec3 v2)
        {
            return new vec3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }
        // Override -+ operator
        public static vec3 operator +(vec3 v1, vec3 v2)
        {
            return new vec3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
    }

    class Component
    {
        // Store a unique ID
        public int ID;
        // Store the name of the component
        public string name;
        // Store if there is a limit of one per entity
        private bool onePerEntity;
        // Base component has a name, and flag to limit one per entitiy
        public Component(string _name, bool _limitOne) 
        {
            ID = DateTime.Now.Millisecond + DateTime.Now.Second;
            name = _name;
            onePerEntity = _limitOne;
        }
        // Check the max on this entity
        public bool IsLimitedToOne() { return onePerEntity; }
        public virtual void Update() { }
    }
}
