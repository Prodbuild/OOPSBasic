using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Polymorphism
{
    public abstract class Car
    {
        public abstract void Move();

        public virtual void MoveFast()
        {
            Console.WriteLine("Car:MoveFast()");
        }
    }
    public class CarA : Car
    {
        public override void Move()
        {
            Console.WriteLine("CarA:Move()");
        }
        public override void MoveFast()
        {
            Console.WriteLine("CarA:MoveFast()");
        }
    }
    public class CarB : Car
    {
        public override void Move()
        {
            Console.WriteLine("CarB:Move()");
        }
    }
}
