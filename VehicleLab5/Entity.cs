using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    // Base entity class for components to be added to
    class Entity
    {
        
        public int ID;
        public string name;
        public vec3 transform;

        public List<Component> components;

        public Entity(string _name)
        {
            ID = DateTime.Now.Millisecond + DateTime.Now.Second;
            name = _name;
            components = new List<Component>();
        }
        // Update all components and this entity
        // Should use delta time
        public void Update()
        {
            int length = components.Count;
            // Call update on all components
            for (int i = 0; i < length; i++)
            {
                components[i].Update();
            }
        }
        // Add a component to this entity
        public void AddComponent(Component _comp)
        {
            // Get length of list
            int length = components.Count;
            if (length > 0)
            {
                // Check for a matching component within the list
                for (int i = 0; i < length; i++)
                {
                    // If a match is found - based on name
                    if (components[i].name == _comp.name)
                        // Check if there is a limit of one for this entity
                        if (_comp.IsLimitedToOne() == true)
                            // If so return from function and do not add to list
                            return;
                }
            }
            // If we clear loop without returning then add this component to the list
            components.Add(_comp);
        }
    }
}
