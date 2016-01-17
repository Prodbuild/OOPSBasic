using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Method_Overloading
{
    public class MethodOverload
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Addess { get; set; }



        public void Print(int id)
        {
            this.Id = id;
            Console.WriteLine(Convert.ToString(id));
        }

        public void Print(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void Print(int id, string name, string address)
        {
            this.Id = id;
            this.Name = name;
            this.Addess = address;
        }

        public int Print(int id, int df)
        {
            return this.Id;
        }

    }
}
