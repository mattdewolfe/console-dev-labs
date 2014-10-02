using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
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
