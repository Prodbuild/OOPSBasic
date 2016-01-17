using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Method_Hiding
{
    public class Customer
    {

        public void Sample()
        {
            Console.WriteLine("SampleClass:Sample()");
        }
    }


    public class GoldCustomer : Customer
    {
        new public void Sample()
        {
            Console.WriteLine("GoldCustomer:Sample()");
        }
    }

    public class SilverCustomer : Customer
    {
        new public void Sample()
        {
            Console.WriteLine("SilverCustomer:Sample()");
        }
    }
}
