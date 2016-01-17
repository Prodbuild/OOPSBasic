using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Abstraction.VirtualClass
{
    public class VirtualClass
    {
        private string _name;
        public string Name
        {
            get
            { return this._name; }

            set
            { this._name = value; }
        }

        public virtual void GetName()
        {
            Console.WriteLine(this.Name);
        }

    }

    public class DeriveClass : VirtualClass
    {

        public override void GetName()
        {
            Console.WriteLine("the name is DeriveClass");
        }

    }

    class ClassA : DeriveClass
    {

        new public virtual void GetName()
        {
            Console.WriteLine("The method has been hidden");
        }

    }
}
