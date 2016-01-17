
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsBasics.Inheritance
{
    public class BaseClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public BaseClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        public void Show()
        {
            Console.WriteLine("Id : " + Convert.ToString(this.Id));
            Console.WriteLine("Name : " + this.Name);

        }

        public void ShowName(string input)
        {
            switch (input)
            {
                case "name":
                    Console.WriteLine("Name:" + this.Name);
                    break;
                case "Id":
                    Console.WriteLine("Id" + this.Id.ToString());
                    break;
                default:
                    Console.WriteLine("Nothing to print");
                    break;
            }
        }

        protected internal void Print()
        {
            Console.WriteLine("Hello in printing function");
        }

    }

    public class DeriveClass : BaseClass
    {

        public string Address { get; set; }

        public DeriveClass(int id, string name, string address)
            : base(id, name)
        {
            this.Address = address;
        }


        public void ShowAddress()
        {
            base.Show();
            Console.WriteLine("Address: " + this.Address);
        }

        public void ShowName(string input, string preference)
        {
            switch (input)
            {
                case "name":
                    Console.WriteLine(preference + this.Name);
                    break;
                case "Id":
                    Console.WriteLine(preference + this.Id.ToString());
                    break;
                default:
                    Console.WriteLine("Nothing to print");
                    break;
            }
        }

        public void PrintProperties()
        {
            base.Print();
            Console.WriteLine("Address: " + this.Address);
        }

    }
}
