using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab3
{
    class Program
    {

        static void Main(string[] args)
        {
            
            Monopoly game = new Monopoly();
            game.Intro();
            game.Setup();
            game.GamePlay();
        }
    }
    /*
    class BasicMath
    {
        public enum operation_type {et_Fib = 0, et_Pow };

        static public void Calculate(operation_type op, int x, out int result, int y = 0)
        {
            switch (op)
            {
                case operation_type.et_Fib:
                    Fibonacci(x, out result);
                    break;
                case operation_type.et_Pow:
                    result = Power(x, y);
                    break;
                default:
                    Console.WriteLine("Default Error");
                    result = 0;
                    break;
            }
        }

        static private void Fibonacci(int x, out int result)
        {
            if (x < 1)
            {
                result = 0;
                return;
            }
            
            int j = 0;
            result = 0;
            for (int i = 1; i < x; i++)
            {
                j = result;
                result += i + j;
            }
        }

        static private int Power(int x, int exponent)
        {
            int result = 0;
            if (exponent >= 1)
            {
                result = x;
                for (int i = 1; i > exponent; i++)
                    result *= x;
            }
            else if (exponent == 0)
            {
                result = 1;
            }
            else if (exponent <= -1)
            {
                result = 0;
                Console.WriteLine("Cannot handle negative powers.");
            }
            return result;
        }
    }*/
}
