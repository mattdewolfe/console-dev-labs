using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    // Enum for input event
    enum INPUTACTION { eIA_Move = 0, eIA_Quit, eIA_Invalid };
    // Enum for current game state
    enum GAMESTATE { eGS_Menu = 0, eGS_Load, eGS_Play, eGS_End };

    class Game
    {     
        // Create an input handler
        public Input inputHandler;
        // Input action
        private INPUTACTION inputAction;
        // Store number of players
        private int playerCount;
        private int[] playerEntID;
        // List of all entities in the game world
        public List<Entity> entities;
        // Track if the game is over
        public bool gameOver;
        // Enum for controller game state   
        GAMESTATE gameState;

        public Game(int _players)
        {
            entities = new List<Entity>();
            inputHandler = new Input();
            playerCount = _players;
            playerEntID = new int[_players];
            gameOver = false;
            gameState = GAMESTATE.eGS_Menu;
            GameLoop();
        }
        public void PlayerVehicleChoice()
        {
            Console.WriteLine(" Press 1 to select the Car.");
            Console.WriteLine(" Press 2 to select the Boat.");
            Console.WriteLine(" Press 3 to select the Jet.");
            int choice = -1;
            // Loop until player has made a valid choice
            while (!gameOver)
            {
                choice = inputHandler.GetIntValue();
                if (choice > 0 && choice < 4)
                {
                    switch (choice)
                    {
                        case 1:
                            AddCar(0);
                            break;
                        case 2:
                            AddBoat(0);
                            break;
                        case 3:
                            AddJet(0);
                            break;
                    }
                    gameState = GAMESTATE.eGS_Load;
                    break;
                }
            }
        }
        public void GameLoop()
        {
            while (!gameOver)
            {
                switch (gameState)
                {
                    case GAMESTATE.eGS_Menu:
                        PlayerVehicleChoice();
                        break;

                    case GAMESTATE.eGS_Load:
                        LoadGame();
                        break;

                    case GAMESTATE.eGS_Play:             
                        RunGame();
                        break;

                    case GAMESTATE.eGS_End:
                        System.Environment.Exit(1);
                        break;

                    default:
                        break;
                }
            }
        }
        public void RunGame()
        {
            Console.Clear();
            Console.WriteLine("Press ESC to stop the magic!");
            // If the game is still running, update and recall function
            if (gameOver == false)
            {
                int count = entities.Count();
                for (int i = 0; i < count; i++)
                {
                    entities[i].Update();
                }
            }
            inputAction = inputHandler.HandleKeyPress(Console.ReadKey(true).Key);
            CheckGameState();  
        }
        // Check if Escape was pressed or a player has reached the end
        public void CheckGameState()
        {
            if (inputAction == INPUTACTION.eIA_Quit)
                gameState = GAMESTATE.eGS_End;
            else if (inputAction == INPUTACTION.eIA_Move)
            {
                // Loop through entity array
                for (int i = 0; i < entities.Count; i++)
                {
                    // Find entity with ID that matches the players stored ent ID
                    if (entities[i].ID == playerEntID[0])
                    {
                        entities[i].Move();
                    }
                }
            }
        }
        // Load our vehicles - this would be done with an external file normally
        public void LoadGame()
        {
            AddCar();
            gameState = GAMESTATE.eGS_Play;
        }
        public void AddCar(int _currentPlayer = -1)
        {
            Entity car = new Entity("Car");
            // If currentplayer does not equal -1
            // This is not an AI, store the entity ID for this player
            if (_currentPlayer != -1)
            {
                playerEntID[_currentPlayer] = car.ID;
            }
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
        public void AddBoat(int _currentPlayer = -1)
        {
            Entity boat = new Entity("Boat");
            // If currentplayer does not equal -1
            // This is not an AI, store the entity ID for this player
            if (_currentPlayer != -1)
            {
                playerEntID[_currentPlayer] = boat.ID;
            }
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
        public void AddJet(int _currentPlayer = -1)
        {
            Entity jet = new Entity("Jet");
            // If currentplayer does not equal -1
            // This is not an AI, store the entity ID for this player
            if (_currentPlayer != -1)
            {
                playerEntID[_currentPlayer] = jet.ID;
            }
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
