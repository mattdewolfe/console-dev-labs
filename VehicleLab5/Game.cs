using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Game
    {
        // Create an input handler
        public Input inputHandler;
        // Store number of players
        public int playerCount;
        // List of all entities in the game world
        public List<Entity> entities;
        // Track if the game is over
        public bool gameOver;

        public Game(int _players)
        {
            entities = new List<Entity>();
            inputHandler = new Input();
            playerCount = _players;
            gameOver = false;
            PlayerVehicleChoice();
            SetupVehicles();
            RunGame();
        }
        public void PlayerVehicleChoice()
        {
            Console.WriteLine(" Press 1 to select the Car.");
            Console.WriteLine(" Press 2 to select the Boat.");
            Console.WriteLine(" Press 3 to select the Jet.");
        }
        public void RunGame()
        {
            Console.WriteLine("Press ESC to stop");
            while (!Console.KeyAvailable) 
            {
                    // If the game is still running, update and recall function
                if (gameOver == false)
                {
                    int count = entities.Count();
                    for (int i = 0; i < count; i++)
                    {
                        entities[i].Update();
                    }
                    CheckGameState();
                }
                inputHandler.HandleKeyPress(Console.ReadKey(true).Key);
            }                   
        }
        // Check tto see if any player has reached the end of the race
        public void CheckGameState()
        {
            //RunGame();
        }
        // Load our vehicles - this would be done with an external file normally
        public void SetupVehicles()
        {
            AddCar();
            AddBoat();
            AddJet();
        }
        public void AddCar()
        {
            Entity car = new Entity("Car");
            string[] sprite = 
            {"   _", 
             "  /t\\___",
             " (o_|__o)"};
            car.AddComponent(new Chassis("Steel"));
            // Create engine to add to car, and keep refernce to it to pass to transmission
            Engine carEng = new Engine(250);
            car.AddComponent(carEng);
            car.AddComponent(new Transmission(carEng, 5));
            car.AddComponent(new PhysicsBody(1000));
            car.AddComponent(new Sprite(sprite, 0, 0));
            entities.Add(car);
        }
        public void AddBoat()
        {
            Entity boat = new Entity("Boat");
            string[] sprite = 
            {"  ++", 
             " /_#\\___",
             " \\_____/"};
            boat.AddComponent(new Chassis("Fiberglass"));
            boat.AddComponent(new Engine(75));
            boat.AddComponent(new PhysicsBody(400));
            boat.AddComponent(new Sprite(sprite, 0, 10));
            entities.Add(boat);
        }
        public void AddJet()
        {
            Entity jet = new Entity("Jet");
            string[] sprite = 
            {"\\\\", 
             "->===//==\\",
             "   -//"};
            jet.AddComponent(new Chassis("Aluminum"));
            jet.AddComponent(new Engine(750));
            jet.AddComponent(new PhysicsBody(1200));
            jet.AddComponent(new Sprite(sprite, 0, 20));
            entities.Add(jet);
        }
    }
}
