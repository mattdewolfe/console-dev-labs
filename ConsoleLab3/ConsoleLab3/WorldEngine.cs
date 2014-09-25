using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleLab3
{
   /* class WorldEngine
    {
        private List<Entity> entities;
        private Stopwatch timer;

        // Reservers 25 positions in entity list, unless specified otherwises
        public WorldEngine(int _capacity = 25)
        {
            timer = new Stopwatch();
            timer.Start();
            entities = new List<Entity>(_capacity);
        }

        // Add an entity to the factory
        public void AddEntity(Entity ent)
        {
            // Set the unique ID for this object
            ent.SetID((int)(timer.ElapsedMilliseconds*1000));
            // Then add into 
            entities.Add(ent);
        }
        // Remove the given entity
        public void RemoveEntity(Entity ent)
        {
            entities.Remove(ent);
        }
        // Rmove an entity from the list based on ID
        public void RemoveByID(int _ID)
        {
            // Iterate through list and find matching entity
            foreach (Entity ent in entities) 
            {
                // If entity ID matches search ID
                if (ent.GetID() == _ID)
                {
                    // Remove from list and break loop
                    entities.Remove(ent);
                    break;
                }
            }
        }
        // Sort the list based on distance from the Entity passed in
        public void SortByDistance(Entity _center)
        {

        }
    }*/
}
