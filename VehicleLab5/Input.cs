using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleLab5
{
    class Input
    {
        // Store the users information
        string info;

        public Input() 
        {
            
        }
        // Handle user input and passback action for game loop to take
        public INPUTACTION HandleKeyPress(ConsoleKey _key)
        {
            switch (_key)
            {
                case ConsoleKey.RightArrow:
                    return INPUTACTION.eIA_Move;
                    
                case ConsoleKey.LeftArrow:
                    return INPUTACTION.eIA_Move;
                    
                case ConsoleKey.Escape:
                    return INPUTACTION.eIA_Quit;
                    
                default:
                    return INPUTACTION.eIA_Invalid;          
            }
        }
        public int GetIntValue()
        {
            string input = Console.ReadLine();
            // ToInt32 can throw FormatException or OverflowException. 
            int numVal = 0;
            try
            {
                numVal = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
            if (numVal < Int32.MaxValue)
            {
                return numVal;
            }
            else
            {
                return -1;
            }
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
                    return -1;
            }
        }
    }
}
