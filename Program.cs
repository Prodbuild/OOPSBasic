using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPsBasics.Abstraction;
using OOPsBasics.Inheritance;
using OOPsBasics.Method_Overloading;
using OOPsBasics.Polymorphism;
using OOPsBasics.Method_Hiding;

namespace OOPsBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            //DeriveClass objDerive = new DeriveClass(123, "xyz", "mno");
            ////BaseClass objBase = new BaseClass(321, "shamajit");
            //objBase.Show();

            //AbstractClass objAbs = new DeriveFromAbstractClass();
            //DeriveFromAbstractClass objDerive = new DeriveFromAbstractClass();
            //objDerive.GetSpecificId();

            //MethodOverload oberload = new MethodOverload();


            #region Polymorphism

            Console.WriteLine("========================== Method Overriding - STARTS ================");

            Car[] basecar = new Car[] {
                new CarA(),
                new CarB()
            };

            basecar[0].Move();
            basecar[0].MoveFast();

            Console.WriteLine("=======================================================================");

            basecar[1].Move();
            basecar[1].MoveFast();

            Console.WriteLine("========================== Method Overriding - ENDS ==================");


            Console.WriteLine("========================== Method Hiding - STARTS ====================");

            Customer[] customerCollection = new Customer[]{
                new GoldCustomer(),
                new SilverCustomer()
            };

            customerCollection[0].Sample();
            customerCollection[1].Sample();

            var goldCust = new GoldCustomer();
            goldCust.Sample();

            Console.WriteLine("==================================================================");

            var silverCust = new SilverCustomer();
            silverCust.Sample();

            Console.WriteLine("========================== Method Hiding - ENDS ======================");


            #endregion

            Console.ReadLine();
        }
    }
}
