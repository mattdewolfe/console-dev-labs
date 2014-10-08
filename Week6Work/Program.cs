using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Work
{
    class Airplane
    {
        public Airplane() { }
        static public void OnCreate(System.Object _obj, int _timeCreated)
        {
            Console.WriteLine("Airplane Created");
        }
    }

    class Axe
    {
        public Axe() { }
        // As this is state, it won't have access to member varialbes of this object
        static public void OnCreate(System.Object _obj, int _timeCreated)
        {
            Console.WriteLine("Axe Created");
        }
    }

    class WorldEngine
    {
        public delegate void CreateCallback(System.Object _obj, int _timeCreated);
        public enum ObjectTypes { eOT_Airplane = 0, eOT_Axe };
        public WorldEngine() { }
        public void CreateObject(ObjectTypes type, CreateCallback cb)
        {
            switch (type)
            {
                case ObjectTypes.eOT_Airplane:
                    Airplane p = new Airplane();
                    cb(p, 5);
                    break;
                case ObjectTypes.eOT_Axe:
                    Axe x = new Axe();
                    cb(x, 5);
                    break;
                default:
                    break;
            }
        }
    }

    class Program
    {
        delegate int Transformer(int x);
        static void Main(string[] args)
        {
            WorldEngine engine = new WorldEngine();
            engine.CreateObject(WorldEngine.ObjectTypes.eOT_Airplane, Airplane.OnCreate);
            engine.CreateObject(WorldEngine.ObjectTypes.eOT_Axe, Axe.OnCreate);
        }
    }
    class Delegates
    {
        // Define a delegate type
        public delegate int CityStates(int _num);
        // Declare a delegate of a specific type
        public CityStates allyRecount;
        // Standard int we will update with our delegate 
        public int allies;

        Delegates()
        {
            allies = allyRecount(0);
        }
        // Calling a function that uses the delegate to update a value
        void Update(int val)
        {
            allies = Allies(val);
            Console.Write(allies);
        }
        // Function definition of the delegate
        public int Allies(int val)
        {
            return val * 2;
        }
    }
}
