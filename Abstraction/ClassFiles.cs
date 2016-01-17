using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Abstraction
{
    public abstract class AbstractClass
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public AbstractClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        protected abstract int GetId();
        public abstract string GetName();
    }
    public class DeriveFromAbstractClass : AbstractClass
    {

        public string Address { get; set; }
        public DeriveFromAbstractClass(int id, string name, string address)
            : base(id, name)
        {
            this.Address = address;
        }
        protected override int GetId()
        {
            return this.Id;
        }
        public override string GetName()
        {
            Console.WriteLine("name :" + this.Name);
            return string.Empty;
        }
        public int GetSpecificId()
        {
            return this.GetId();
        }
    }

    //public class ClassC : DeriveFromAbstractClass
    //{
    //    protected sealed override int GetId()
    //    {
    //        return base.GetId();
    //    }
    //}






    public abstract class ClassB : AbstractClass
    {
        public string Address { get; set; }
        public ClassB(int id, string name, string address)
            : base(id, name)
        {
            this.Address = address;
        }
        protected override abstract int GetId();


        public override string GetName()
        {
            Console.WriteLine("name :" + this.Name);
            return string.Empty;
        }

        public int GetSpecificId()
        {
            return this.GetId();
        }


    }
}
