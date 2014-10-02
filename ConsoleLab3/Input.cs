using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Input
    {
        public enum set_type { nothing = 0, type, position, direction, quit };
        // Store the users request
        public set_type currentTask;
        // Values for parsing user input on information to alter
        private const string setType = "type";
        private const string setDirection = "direction";
        private const string setPosition = "position";
        private const string quit = "quit";
        public string[] pieces = {"Thimble", "Shoe", "Dog", "Hat"};
        // Store the users information
        string info;

        public Input() 
        {
            currentTask = set_type.nothing;
        }
        // Take string input and return the value for number of players
        public int SetIntValue(string input)
        {
            switch (input)
            {
                case "1":
                    return 1;
                case "2":
                    return 2;
                case "3":
                    return 3;
                case "4":
                    return 4;
                default:
                    return 0;
            }
        }
        public void ParseRequest(string _input)
        {
            // Minimize input before parsing
            _input = _input.ToLower();
            switch (_input)
            {
                case setType:
                    currentTask = set_type.type;
                    break;
                case setDirection:
                    currentTask = set_type.direction;
                    break;
                case setPosition:
                    currentTask = set_type.position;
                    break;
                case quit:
                    currentTask = set_type.quit;
                    break;
                default:
                    currentTask = set_type.nothing;
                    Console.WriteLine("Unknown input. Please select 'type', 'direction' or 'position'\n");
                    break;
            }
        }
    }
}
